using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls;
using DataAccess;
using PdfSharp.Pdf;


namespace SoftwareCentral
{
    public partial class frmDeliveryDataPdf : Form
    {
        public AccesADades accesADades { private get; set; }
        private DataSet dts;

        private string tableName;
        private string query;

        private int deliveryNumber;

        private string origin;
        public string Origin
        {
            set { origin = value; }
        }
        public frmDeliveryDataPdf()
        {
            InitializeComponent();
        }

        private string GenerateDeliveryCode()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{swCodPlanet.getValue().Substring(0, 2).ToUpper()}");
            sb.Append($"{origin.Substring(0, 2).ToUpper()}");
            sb.Append($"{swCodShip.getValue().Substring(0, 2).ToUpper()}");
            int numRows = dts.Tables[0].Rows.Count;
            int lastCode = 0;
            if (numRows > 0)
            {
                string lastCodeStr = dts.Tables[0].Rows[numRows - 1]["CodeDelivery"].ToString();
                lastCode = int.Parse(lastCodeStr.Substring(6, 6));
            }
            sb.Append($"{(lastCode + 1):D6}");

            this.deliveryNumber = lastCode + 1;

            return sb.ToString();
        }
        private bool ValidateAllControls()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is SWTextBox swTextBox)
                {
                    if (swTextBox.required && string.IsNullOrEmpty(swTextBox.Text))
                    {
                        lblError.Visible = true;
                        return false;
                    }
                }
            }
            lblError.Visible = false;
            return true;
        }

        private void AddNewRow()
        {
            DataRow row = dts.Tables[0].NewRow();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is SWTextBox swTxt)
                {
                    if (swTxt.dadaPermesa == SWTextBox.TipusDada.Nombre)
                    {
                        row[swTxt.columnName] = int.Parse(swTxt.Text);
                    }
                    else
                    {
                        row[swTxt.columnName] = swTxt.Text;
                    }
                }
            }
            row[dtpDelivery.Tag.ToString()] = dtpDelivery.Value;

            dts.Tables[tableName.ToString()].Rows.Add(row);
        }

        private void BuildPdf()
        {
            List<DeliveryItem> items = new List<DeliveryItem>();
            items.Add(new DeliveryItem("deliveryNumber", deliveryNumber.ToString()));
            items.Add(new DeliveryItem("deliveryCode", swTxtDeliveryCode.Text));
            items.Add(new DeliveryItem("origin", this.origin));
            items.Add(new DeliveryItem("destination", swCodPlanet.getValue()));
            items.Add(new DeliveryItem("shipCode", swCodShip.getValue()));
            items.Add(new DeliveryItem("deliveryDate", dtpDelivery.Value.ToString()));

            PdfBuilder pdfBuilder = new PdfBuilder();
            pdfBuilder.Delivery = items;
            pdfBuilder.CreatePdf();

            int numRows = dts.Tables[0].Rows.Count;
            string pdfFilePath = $"./{this.deliveryNumber}.pdf";
            byte[] bytes = System.IO.File.ReadAllBytes(pdfFilePath);
            dts.Tables[0].Rows[numRows - 1]["DocumentPdf"] =  bytes;
            accesADades.Actualitzar(query, dts);
        }

        private void frmDeliveryDataPdf_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            this.tableName = "DeliveryDataPdf";
            this.query = $"SELECT * FROM {this.tableName}";
            dts = accesADades.PortarTaula(this.tableName);
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateAllControls()) return;
            swTxtDeliveryCode.Text = GenerateDeliveryCode();
            AddNewRow();
            int updatedRows = accesADades.Actualitzar(query, dts);

            if (updatedRows != -1)
            {
                dts = accesADades.PortarTaula(this.tableName);
                BuildPdf();
            }
        }
    }
}
