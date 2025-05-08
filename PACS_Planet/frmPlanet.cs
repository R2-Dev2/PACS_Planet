using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareCentral;
using Model;
using Encrypting;
using FTP;
using Workflow;
using FileUtils;
using static Workflow.PACSMessage;

namespace PACS_Planet
{
    public partial class frmPlanet : Form
    {
        private PlanetWorkflow workflow;
        private Planet planet;
        private Client ftpClient;
        private FileGenerator fileGenerator;
        public frmPlanet()
        {
            InitializeComponent();
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

            string portListenStr = planetRow["PortPlanetL"].ToString();
            if (int.TryParse(portListenStr, out int portListen))
            {
                planet.PortListen = portListen;
            }
            else
            {
                MessageBox.Show("Error loading configuration data. The program cannot start");
                this.Close();
            }
        }

        public void OnMessageReceived(object sender, EventArgs e)
        {
            string msg = ((Client.MessageEventArgs)e).msg;
            string ip = ((Client.MessageEventArgs)e).ip;
            AddToListBox("New message received");
            ProcessMessage(msg, ip);
        }

        private void ProcessMessage(string msg, string ip)
        {
            PACSMessage entryMsg = PACSMessage.ParseMessage(msg);
            if(entryMsg == null)
            {
                if(workflow.step == 1)
                {
                    workflow.validateEncrypted(msg);
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
                        ftpClient.sendPort = workflow.spaceShipPortL;
                        updateLabel(lblMsgStatus, "Delivery scheduled properly", true);
                    }
                    else
                    {
                        updateLabel(lblMsgStatus, "Delivery not scheduled", false);
                    }
                }
            }

        }

        private void OcultarEncabezados(TabControl tabControl1)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
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

        private void button7_Click(object sender, EventArgs e)
        {
            btn2_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            btn3_Click(sender, e);
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

        private void frmPlanet_Load(object sender, EventArgs e)
        {
            loadPlanetData();
            this.ftpClient = new Client();
            this.ftpClient.listenPort = planet.PortListen;
            this.ftpClient.MessageReceived += new System.EventHandler(OnMessageReceived);
            lblTitle.Text = planet.DescPlanet;
            OcultarEncabezados(tabControl);
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStartListening_Click(object sender, EventArgs e)
        {
            ftpClient.StartListening();
            AddToListBox($"Listening to messages on port {ftpClient.listenPort}");
        }

        private void btnStopListening_Click(object sender, EventArgs e)
        {
            ftpClient.StopListening();
            AddToListBox("Stopped listening to messages");
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string msg = workflow.GetValidationMessage();
            ftpClient.SendMessage(msg);
            AddToListBox($"Sending message {msg} to IP {ftpClient.ipDestination} via {ftpClient.sendPort}");

            tabControl.Invoke((MethodInvoker)delegate
            {
                if (tabControl.SelectedIndex < tabControl.TabCount - 1)
                {
                    tabControl.SelectedIndex = tabControl.SelectedIndex + 1;
                }
            });
        }

        private void btnDesencriptarCred_Click(object sender, EventArgs e)
        {
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerarFitxer_Click(object sender, EventArgs e)
        {
        }

        private void btnDecodificar_Click(object sender, EventArgs e)
        {
            fileGenerator.EncodeFilesAndSum();
        }

        private void btnEnviar3_Click(object sender, EventArgs e)
        {
        }
    }
}
