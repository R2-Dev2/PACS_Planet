﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareCentral;
using Model;
using FTP;
using Workflow;
using Encrypting;
using FileUtils;
using static Workflow.PACSMessage;

namespace PACS_Planet
{
    public partial class frmPlanetFinal : Form
    {
        bool isListening = false;
        private PlanetWorkflow workflow;
        private Planet planet;
        private Client ftpClient;
        private FileGenerator fileGenerator;
        private string planetSum;
        private string spaceShipSum;
        public frmPlanetFinal()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPage1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPage2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPage3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPage4;
        }

        private void MakeButtonCircular(Button btn)
        {
            int diameter = Math.Min(btn.Width, btn.Height);
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, diameter, diameter);
            btn.Region = new Region(path);

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.White;

            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size, FontStyle.Bold);

            btn.AutoSize = false;
            btn.Size = new Size(diameter, diameter);
            btn.Padding = new Padding(0);
        }

        public void OnMessageReceived(object sender, EventArgs e)
        {
            string msg = ((Client.MessageEventArgs)e).msg;
            string ip = ((Client.MessageEventArgs)e).ip;
            ProcessMessage(msg, ip);
        }

        private void ProcessMessage(string msg, string ip)
        {
            PACSMessage entryMsg = PACSMessage.ParseMessage(msg);
            if (entryMsg == null)
            {
                if(workflow is null)
                {
                    updateLabel(lblMsgStatus, "Wrong message format", false);
                }
                else if(workflow.step == 2)
                {
                    spaceShipSum = msg;
                    enableButton(btnComprovar, true);
                }
            }
            else
            {
                if (MessageType.ER.Equals(entryMsg.type))
                {
                    updateLabel(lblTitle1, "New Entry Access requested");
                    this.workflow = new PlanetWorkflow();
                    this.workflow.PlanetId = this.planet.IdPlanet;
                    if (workflow.CheckAccess((EntryMessage)entryMsg, ip))
                    {
                        ftpClient.ipDestination = workflow.spaceShipIp;
                        ftpClient.messagePortS = workflow.shipMsgPort;
                        ftpClient.filePortS = workflow.shipFilePort;
                        updateLabel(lblMsgStatus, "Delivery scheduled properly", true);
                    }
                    else
                    {
                        updateLabel(lblMsgStatus, "Delivery not scheduled", false);
                    }
                    enableButton(btnSendResponse1, true);
                }
            }

        }

        private void GenerateFilesAndZip()
        {
            LoadFileGenerator();
            fileGenerator.GenerateAndZipFiles();
        }

        private void LoadFileGenerator()
        {
            fileGenerator = new FileGenerator();
            fileGenerator.config = this.planet.Encoding;
            fileGenerator.ZipFinished += new System.EventHandler(OnZipFinished);
            fileGenerator.SumFinished += new System.EventHandler(OnSumFinished);
            fileGenerator.codifications = DatabaseHelper.GetCodifications(planet.IdPlanet);
        }


        public void OnZipFinished(object sender, EventArgs e)
        {
            string path = ((FileGenerator.ZipFinishedEventArgs)e).path;
            AddToListBox($"ZIP ready to send: {path}");
            enableButton(btnDecodificar, true);
        }

        public void OnCredentialReceived(object sender, EventArgs e)
        {
            string credential = ((Client.CredMessgaeEventArgs)e).credential;
            enableButton(btnDesencriptarCred, true);
            workflow.validateEncrypted(credential);
            AddToListBox("Credential received");
            AddToListBox(credential);

        }

        public void OnSumFinished(object sender, EventArgs e)
        {
            long sum = ((FileGenerator.SumFinishedEventArgs)e).sum;
            planetSum = sum.ToString();
            AddToListBox($"Sum finished");
        }

        private void AddToListBox(string msg)
        {
            if (lbxInfo.InvokeRequired)
            {
                lbxInfo.Invoke((MethodInvoker)delegate
                {
                    lbxInfo.Items.Add(msg);
                });
            }
            else lbxInfo.Items.Add(msg);
        }

        private void updateLabel(Label lbl, string message, bool result)
        {
            Color color;
            if (result)
            {
                color = Color.Green;
            }
            else
            {
                color = Color.Red;
            }

            updateLabel(lbl, message, color);
        }

        private void updateLabel(Label lbl, string message, Color? color = null)
        {
            if (color is null)
            {
                color = Color.Black;
            }
            if (lbl.InvokeRequired)
            {
                lbl.Invoke((MethodInvoker)delegate
                {
                    lbl.Visible = true;
                    lbl.ForeColor = (Color)color;
                    lbl.Text = message;
                    lbl.Refresh();
                });
            }
            else
            {
                lbl.Visible = true;
                lbl.ForeColor = (Color)color;
                lbl.Text = message;
                lbl.Refresh();
            }
        }

        private void enableButton(Button btn, bool isEnable)
        {
            if (btn.InvokeRequired)
            {
                btn.Invoke((MethodInvoker)delegate
                {
                    btn.Enabled = isEnable;
                });
            }
            else
            {
                btn.Enabled = isEnable;
            }
        }

        private void nextTab()
        {
            tabControl.Invoke((MethodInvoker)delegate
            {
                if (tabControl.SelectedIndex < tabControl.TabCount - 1)
                {
                    tabControl.SelectedIndex = tabControl.SelectedIndex + 1;
                }
            });
        }

        private void frmPlanetFinal_Load(object sender, EventArgs e)
        {
            loadPlanetData();
            this.ftpClient = new Client();
            this.ftpClient.messagePortL = planet.MessagePort;
            this.ftpClient.filePortL = planet.FilePort;
            this.ftpClient.MessageReceived += new System.EventHandler(OnMessageReceived);
            this.ftpClient.CredentialReceived += new System.EventHandler(OnCredentialReceived);

            lblTitle.Text = planet.DescPlanet;
            OcultarEncabezados(tabControl);
            MakeButtonCircular(btn1);
            MakeButtonCircular(btn2);
            MakeButtonCircular(btn3);
            MakeButtonCircular(btn4);
        }

        private void loadPlanetData()
        {
            planet = new Planet();
            if (!planet.loadConfig())
            {
                MessageBox.Show("Error loading configuration data. The program cannot start");
                this.Close();
            }

            DataRow planetRow = DatabaseHelper.PlanetInfo(planet.CodePlanet);

            planet.IdPlanet = planetRow["idPlanet"].ToString();
            planet.DescPlanet = planetRow["DescPlanet"].ToString();
            planet.PlanetPicture = planetRow["PlanetPicture"].ToString();

            Image img = MyFileUtils.GetImageFromUrl(planet.PlanetPicture);
            if (img is null)
            {
                img = pbPlanet.ErrorImage;
            }
            pbPlanet.Image = img;
            
            string messagePortStr = planetRow["PortPlanetL"].ToString();
            string filePortStr = planetRow["PortPlanetS"].ToString();
            if (int.TryParse(messagePortStr, out int msgPort) && int.TryParse(filePortStr, out int filePort))
            {
                planet.MessagePort = msgPort;
                planet.FilePort = filePort;
            }
            else
            {
                MessageBox.Show("Error loading configuration data. The program cannot start");
                this.Close();
            }
        }

        private void OcultarEncabezados(TabControl tabControl1)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }

        private void btnStartListening_Click(object sender, EventArgs e)
        {
            if (!isListening)
            {
                ftpClient.StartListening();
                AddToListBox($"Listening to messages on port {ftpClient.messagePortL}");
                isListening = true;
                btnStartListening.Text = null;
                btnStartListening.BackgroundImage = Properties.Resources.wify;
                btnStartListening.BackgroundImageLayout = ImageLayout.Stretch;
            
            }
            else
            {
                ftpClient.StopListening();
                AddToListBox("Stopped listening to messages");
                isListening = false;
                btnStartListening.Text = null;
                btnStartListening.BackgroundImage = Properties.Resources.nowify;
                btnStartListening.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void pnlClose_Click(object sender, EventArgs e)
        {
            ftpClient.StopListening();
            this.Close();
        }

        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            RSA.GenerateKeys(planet.IdPlanet, planet.CodePlanet);
            AddToListBox("RSA keys generated successfully");
        }

        private void btnNewDelivery_Click(object sender, EventArgs e)
        {
            frmDeliveryDataPdf form = new frmDeliveryDataPdf();
            form.Origin = planet.DescPlanet;
            form.ShowDialog();
        }

        private void btnGenerateCodes_Click(object sender, EventArgs e)
        {
            CodificationGenerator.GeneratePlanetCodification(planet.IdPlanet);
            AddToListBox("Planet codification created successfully");
        }

        private void btnSendResponse1_Click(object sender, EventArgs e)
        {
            string msg = workflow.GetValidationMessage();
            ftpClient.SendMessage(msg);
            nextTab();
        }

        private void btnGenerarFitxer_Click(object sender, EventArgs e)
        {
            GenerateFilesAndZip();
        }
        private void btnEnviar3_Click(object sender, EventArgs e)
        {
            ftpClient.SendFileTCP($"{planet.Encoding.OriginalFilesPath}/PACS.zip");
            nextTab();
        }

        private void btnDesencriptarCred_Click(object sender, EventArgs e)
        {
            workflow.DecryptCredentials(planet.CodePlanet);
            enableButton(btnDesencriptarPDF, true);
        }

        private void btnDesencriptarPDF_Click(object sender, EventArgs e)
        {
            workflow.DecryptDeliveryPdf();
            enableButton(btnCheckPdf, true);
        }

        private void btnComprovar_Click(object sender, EventArgs e)
        {
            bool isValid = workflow.CheckSums(planetSum, spaceShipSum);
            if (isValid){
                AddToListBox("Sums match: ACCESS GRANTED");
            }
            else
            {
                AddToListBox("Sums do not match: ACCES DENIED");
            }
            string msg = workflow.GetValidationMessage();
            ftpClient.SendMessage(msg);
        }

        private void btnEnviar2_Click(object sender, EventArgs e)
        {
            string msg = workflow.GetValidationMessage();
            ftpClient.SendMessage(msg);
            nextTab();
        }

        private void btnCheckPdf_Click(object sender, EventArgs e)
        {
            if (workflow.CheckPdf())
            {
                AddToListBox("Document is correct");
            }
            else
            {
                AddToListBox("Document is incorrect");
            }
            enableButton(btnEnviar2, true);
                
        }

        private void btnDecodificar_Click(object sender, EventArgs e)
        {
            fileGenerator.EncodeFilesAndSum();
            enableButton(btnEnviar3, true);
        }
    }
}