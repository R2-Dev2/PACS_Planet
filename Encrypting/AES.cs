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

        public static byte[] DescryptAesPdf(byte[] key, byte[] iv, byte[] pdfEncrypted)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                using(MemoryStream ms = new MemoryStream(pdfEncrypted))
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                using (MemoryStream result = new MemoryStream())
                {
                    cs.CopyTo(result);
                    return result.ToArray();
                }
            }
        }
    }
}
