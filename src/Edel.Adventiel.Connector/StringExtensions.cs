using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Edel.Adventiel.Connector
{
    public static class StringExtensions
    {
        private const string Ckey = "3/cE34EY1NrWSFAdPcFx5GXXAClANS69hJMYC8z9eFU=";
        private const string Civ = "gMI7TOZxyBN2jBwvEsmsQA==";
        
        public static string Decipher(this string source)
        {
            // Place le texte à déchiffrer dans un tableau d'octets
            var cipheredData = Convert.FromBase64String(source);

            // Place la clé de déchiffrement dans un tableau d'octets
            var sKey = Encoding.UTF8.GetBytes(Ckey);

            // Place le vecteur d'initialisation dans un tableau d'octets
            var sIv = Encoding.UTF8.GetBytes(Civ);

            var rijndael = new RijndaelManaged();
            rijndael.Mode = CipherMode.CBC;

            // Ecris les données déchiffrées dans le MemoryStream
            var decryptor = rijndael.CreateDecryptor(sKey, sIv);
            var ms = new MemoryStream(cipheredData);
            var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read);

            // Place les données déchiffrées dans un tableau d'octet
            var plainTextData = new byte[cipheredData.Length];

            var decryptedByteCount = cs.Read(plainTextData, 0, plainTextData.Length);

            ms.Close();
            cs.Close();

            return Encoding.UTF8.GetString(plainTextData, 0, decryptedByteCount);
        }

        public static string Cipher(this string source)
        {
            // Place le texte à chiffrer dans un tableau d'octets
            var plainText = Encoding.UTF8.GetBytes(source);
            var rijndael = new RijndaelManaged();

            // Place la clé de chiffrement dans un tableau d'octets
            var sKey = Convert.FromBase64String(Ckey);

            // Place le vecteur d'initialisation dans un tableau d'octets
            var sIv = Convert.FromBase64String(Civ);

            
            
            // Définit le mode utilisé
            rijndael.Mode = CipherMode.CBC;

            // Crée le chiffreur AES - Rijndael
            var aesEncryptor = rijndael.CreateEncryptor(sKey, sIv);

            var ms = new MemoryStream();

            // Ecris les données chiffrées dans le MemoryStream
            var cs = new CryptoStream(ms, aesEncryptor, CryptoStreamMode.Write);
            cs.Write(plainText, 0, plainText.Length);
            cs.FlushFinalBlock();


            // Place les données chiffrées dans un tableau d'octet
            var cipherBytes = ms.ToArray();


            ms.Close();
            cs.Close();

            // Place les données chiffrées dans une chaine encodée en Base64
            return Convert.ToBase64String(cipherBytes);

        }
    }
}