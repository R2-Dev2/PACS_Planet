using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace SoftwareCentral
{
    public static class CodificationGenerator
    {
        private static AccesADades accesADades = new AccesADades("SecureCore");

        public static void GeneratePlanetCodification(string idPlanet)
        {
            List<Codification> codes = RandomCodeGenerator.GenerateCodification();
            SaveCodifications(idPlanet, codes);
        }

        private static void SaveCodifications(string idPlanet, List<Codification> codifications)
        {
            string idInnerEncryption = GetInnerEncryptionId(idPlanet);
            if (idInnerEncryption == "")
            {
                CreateInnerEncryption(idPlanet);
                idInnerEncryption = GetInnerEncryptionId(idPlanet);
            }

            UpdateInnerEncryptionData(idInnerEncryption, codifications);
        }

        private static string GetInnerEncryptionId(string idPlanet)
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

        private static void CreateInnerEncryption(string idPlanet)
        {
            string query = "SELECT* FROM InnerEncryption";
            DataSet dts = accesADades.PortarPerConsulta(query);
            DataRow row = dts.Tables[0].NewRow();

            row["idPlanet"] = idPlanet;

            dts.Tables[0].Rows.Add(row);
            accesADades.Actualitzar(query, dts);
        }

        private static void UpdateInnerEncryptionData(string idInnerEncryption, List<Codification> codifications)
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
    }
}
