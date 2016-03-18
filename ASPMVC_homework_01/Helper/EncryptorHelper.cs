using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace ASPMVC_homework_01.Helper
{
    public class EncryptorHelper
    {
        public static string SHA256Encrypt(string parString)
        {
            byte[] SHA256Data = Encoding.UTF8.GetBytes(parString);
            SHA256Managed Sha256 = new SHA256Managed();
            byte[] Result = Sha256.ComputeHash(SHA256Data);
            return Convert.ToBase64String(Result);
        }
    }
}