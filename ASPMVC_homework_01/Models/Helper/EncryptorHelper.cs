using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace ASPMVC_homework_01.Models.Helper
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