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
        private string planetCode;
        private AccesADades accesADades;
        public frmPlanet()
        {
            InitializeComponent();
        }
        private void OcultarEncabezados(TabControl tabControl1)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
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
            RSA.GenerateKeys(planetCode);
        }

        private void btnNewDelivery_Click(object sender, EventArgs e)
        {
            frmDeliveryDataPdf form = new frmDeliveryDataPdf();
            form.ShowDialog();
        }

        private void btnGenerateCodes_Click(object sender, EventArgs e)
        {

        }

        private void frmPlanet_Load(object sender, EventArgs e)
        {
            OcultarEncabezados(tabControl1);
            this.accesADades = new AccesADades("SecureCore");

        }
    }
}
