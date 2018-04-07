using System;
using System.IO;
using System.Security.Cryptography;
using System.ServiceModel.Security;
using System.Text;
using Autumn.Mvc.Data.Repositories;
using Microsoft.AspNetCore.Mvc.Internal;

namespace Edel.Adventiel.Connector
{
    public static class StringExtensions
    {
        private static readonly byte[] salt = Encoding.Unicode.GetBytes("45648z456z");
        private static readonly string password = "toBeOrNotToBe";
        private static readonly int iterations = 2000;


        public static string Encrypt(this string plainText)
        {

            var plainToBytes = Encoding.Unicode.GetBytes(plainText);
            var aes = Aes.Create();
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            aes.Key = pbkdf2.GetBytes(32);
            aes.IV = pbkdf2.GetBytes(16);
            var ms = new MemoryStream();
            using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
            {
                cs.Write(plainToBytes, 0, plainToBytes.Length);
            }

            return Convert.ToBase64String(ms.ToArray());    
        }

        public static string Decrypt(this string crypt)
        {
            var cryptToBytes = Convert.FromBase64String(crypt);
            var aes = Aes.Create();
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            aes.Key = pbkdf2.GetBytes(32); 
            aes.IV = pbkdf2.GetBytes(16);
            var ms = new MemoryStream();
            using (var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
            {
                cs.Write(cryptToBytes, 0, cryptToBytes.Length);
            }

            return Encoding.Unicode.GetString(ms.ToArray());
        }

        
    }
}