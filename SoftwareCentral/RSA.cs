using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Xml;
using System.Data;
using DataAccess;

namespace SoftwareCentral
{
    public static class RSA
    {
        private static string keyName;
        private static string xmlPublicKeyPath = "./planetPublicKey.xml";
        static AccesADades accesADades = new AccesADades("SecureCore");
        private static string query = "Select * From PlanetKeys";

        public static void GenerateKeys(string idPlanet, string codePlanet)
        {
            CspParameters cspp = new CspParameters();
            keyName = codePlanet;

            cspp.KeyContainerName = keyName;

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;

            string publicKey = rsa.ToXmlString(false);

            Dictionary<string, string> dictKeys = new Dictionary<string, string>();
            dictKeys.Add("idPlanet", idPlanet);

            DataSet datasetKeys = accesADades.ExecutaCerca("PlanetKeys", dictKeys);

            if (datasetKeys.Tables[0].Rows.Count > 0)
            {
                datasetKeys.Tables[0].Rows[0]["XMLKey"] = publicKey;
            }
            else
            {
                DataRow row = datasetKeys.Tables[0].NewRow();

                row["XMLKey"] = publicKey;
                row["idPlanet"] = idPlanet;

                datasetKeys.Tables[0].Rows.Add(row);
            }

            accesADades.Actualitzar(query, datasetKeys);

            WriteXmlPublicKey(idPlanet);
        }

        public static string GetPlanetPublickey(string idPlanet)
        {
            Dictionary<string, string> dictKeys = new Dictionary<string, string>();
            dictKeys.Add("idPlanet", idPlanet);

            DataSet datasetKeys = accesADades.ExecutaCerca("PlanetKeys", dictKeys);
            string xmlPublicKey = datasetKeys.Tables[0].Rows[0]["XMLKey"].ToString();

            return xmlPublicKey;
        }

        private static void WriteXmlPublicKey(string idPlanet)
        {
            string xmlPublicKey = GetPlanetPublickey(idPlanet);
            File.WriteAllText(xmlPublicKeyPath, xmlPublicKey);
        }
    }
}
