using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Encrypting
{
    public static class AES
    {
        static AccesADades accesADades = new AccesADades("SecureCore");

        // s'hauria d'afegir una propietat amb el nom del planeta que s'està utilitzant?

        public static byte[] DecryptAesCredentials(byte[] data, string origin)
        {
            byte[] dataDecrypted;

            dataDecrypted = RSA.DecryptRSA(data, origin);

            return dataDecrypted;
        }

        public static void DescryptAesPdf(byte[] dadesXifrades, byte[] key, byte[] iv)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                using (MemoryStream ms = new MemoryStream(dadesXifrades))
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                using (StreamReader sr = new StreamReader(cs))
                {
                    string dadesOriginals = sr.ReadToEnd();

                    // comprovació de les metadades del pdf --> frmDeliveryDataPdf.cs --> BuildPdf
                    // descarregar el pdf de la base de dades 
                }
            }
        }

        private static void DownloadPDF(string codeDelivery)
        {
            string query = $"SELECT DocumentPdf FROM DeliveryDataPdf WHERE CodeDelivery = {codeDelivery}";
            DataSet dts = new DataSet();
            dts = accesADades.PortarPerConsulta(query);


        }
    }
}
