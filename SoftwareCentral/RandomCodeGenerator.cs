using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareCentral
{
    public static class RandomCodeGenerator
    {
        static string[] letters = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
        static RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();

        public static List<Codification> GenerateCodification()
        {
            List<Codification> codeList = new List<Codification>();

            HashSet<string> codifications = new HashSet<string>();
            while (codifications.Count < letters.Length)
            {
                codifications.Add(GenerateRandomCode(3));
            }

            for (int i = 0; i < letters.Length; i++)
            {
                Codification codification = new Codification();
                codification.Letter = letters[i];
                codification.Numbers = codifications.ElementAt(i);

                codeList.Add(codification);
            }

            return codeList;

        }
        private static int GenerateRandomNumber(int max = 9)
        {
            var byteArray = new byte[4];
            provider.GetBytes(byteArray);
            var randomInteger = BitConverter.ToUInt32(byteArray, 0) & int.MaxValue;

            return (int)randomInteger % max;
        }
        
        public static string GenerateRandomCode(int size)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                sb.Append(GenerateRandomNumber());
            }
            return sb.ToString();
        }
    }
}
