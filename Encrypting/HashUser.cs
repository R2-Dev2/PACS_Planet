using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Encrypting
{
    public static class HashUser
    {
        public static byte[] GenerateHashedString(string original)
        {
            using (SHA256 hash = SHA256.Create())
            {
                byte[] hashedBytes = hash.ComputeHash(Convert.FromBase64String(original));
                return hashedBytes;
            }
        }

    }
}
