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
using DataAccess;
using System.Data.SqlClient;

namespace PACS_Planet
{
    public partial class Form1 : Form
    {
        private AccesADades accesADades;
        private string origin;
        public Form1()
        {
            InitializeComponent();
        }

        private string GetIdPlanet(string codePlanet)
        {
            string idPlanet;

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("codePlanet", codePlanet);

            DataSet dataset = accesADades.ExecutaCerca("Planets", dict);
            idPlanet = dataset.Tables[0].Rows[0]["idPlanet"].ToString();

            return idPlanet;
        }
        private void SaveCodifications(List<Codification> codifications)
        {
            string idPlanet = GetIdPlanet(origin);
            string idInnerEncryption = GetInnerEncryptionId(idPlanet);
            if (idInnerEncryption == "")
            {
                CreateInnerEncryption(idPlanet);
                idInnerEncryption = GetInnerEncryptionId(idPlanet);
            }

            UpdateInnerEncryptionData(idInnerEncryption, codifications);
        }

        private string GetInnerEncryptionId(string idPlanet) 
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("idPlanet", idPlanet);

            DataSet dts = accesADades.ExecutaCerca("InnerEncryption", dict);
            string idInnerEncryption = "";
            if (dts.Tables[0].Rows.Count > 0)
            {
                idInnerEncryption = dts.Tables[0].Rows[0]["idPlanet"].ToString();
            }
            return idInnerEncryption;
        }

        private void CreateInnerEncryption(string idPlanet)
        {
            string query = "SELECT* FROM InnerEncryption";
            DataSet dts = accesADades.PortarPerConsulta(query);
            DataRow row = dts.Tables[0].NewRow();

            row["idPlanet"] = idPlanet;

            dts.Tables[0].Rows.Add(row);       
            accesADades.Actualitzar(query, dts);
        }

        private void UpdateInnerEncryptionData(string idInnerEncryption, List<Codification> codifications)
        {
            string query = "SELECT * FROM InnerEncryptionData";
            string deleteQuery = $"DELETE FROM InnerEncryptionData WHERE IdInnerEncryption = {idInnerEncryption};";

            accesADades.ExecutaTransaccioNonQuery(deleteQuery);
            DataSet dts = accesADades.PortarPerConsulta(query);

            foreach (Codification codification in codifications)
            {
                DataRow row = dts.Tables[0].NewRow();
                row["idInnerEncryption"] = idInnerEncryption;
                row["Word"] = codification.Letter;
                row["Numbers"] = codification.Numbers;

                dts.Tables[0].Rows.Add(row);
            }

            accesADades.Actualitzar(query, dts);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDeliveryDataPdf form = new frmDeliveryDataPdf();
            form.Origin = origin;
            form.Show();
        }

        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            RSA.GenerateKeys(origin);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Codification> codes = CodificationGenerator.GenerateCodification();
            SaveCodifications(codes);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            accesADades = new AccesADades("SecureCore");
            this.origin = "RAKA";
        }
    }
}
