using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using SoftwareCentral;

namespace PACS_Planet
{
    public partial class frmPlanet : Form
    {
        private Planet planet;
        private AccesADades accesADades;
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

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("codePlanet", planet.CodePlanet);
            DataSet dataset = accesADades.ExecutaCerca("Planets", dict);
            
            planet.IdPlanet = dataset.Tables[0].Rows[0]["idPlanet"].ToString();
            planet.DescPlanet = dataset.Tables[0].Rows[0]["DescPlanet"].ToString();
            planet.PlanetPicture = dataset.Tables[0].Rows[0]["PlanetPicture"].ToString();
            planet.PortSend = dataset.Tables[0].Rows[0]["PortPlanetS"].ToString();
            
        }

        private void OcultarEncabezados(TabControl tabControl1)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }

        private void AddToListBox(string msg, ListBox lbx)
        {
            if (lbx.InvokeRequired)
            {
                lbx.Invoke((MethodInvoker)delegate
                {
                    lbx.Items.Add(msg);
                });
            }
            else lbx.Items.Add(msg);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
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
            AddToListBox("RSA keys generated successfully", listBox1);
        }

        private void btnNewDelivery_Click(object sender, EventArgs e)
        {
            frmDeliveryDataPdf form = new frmDeliveryDataPdf();
            form.accesADades = accesADades;
            form.Origin = planet.DescPlanet;
            form.ShowDialog();  
        }

        private void btnGenerateCodes_Click(object sender, EventArgs e)
        {
            CodificationGenerator.GeneratePlanetCodification(planet.IdPlanet);
            AddToListBox("Planet codification created successfully", listBox1);
        }

        private void frmPlanet_Load(object sender, EventArgs e)
        {
            this.accesADades = new AccesADades("SecureCore");
            loadPlanetData();

            lblTitle.Text = planet.DescPlanet;
            OcultarEncabezados(tabControl1);
            
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
