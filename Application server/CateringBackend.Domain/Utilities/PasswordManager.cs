using System;
using System.IO;
using System.Security.Cryptography;

namespace CateringBackend.Domain.Utilities
{
    public static class PasswordManager 
    {
        private static readonly string _secretKey = "batSsxJg8NsNZykrgJVY7PjjMEtUYYqF";
        private static readonly string _IV = "8Jkq94mnUlf/Pw7kFqeit5==";

        public static string Encrypt(string plainText)
        {
            byte[] encrypted;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Convert.FromBase64String(_secretKey);
                aes.IV = Convert.FromBase64String(_IV);

                var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using MemoryStream msEncrypt = new();
                using CryptoStream csEncrypt = new(msEncrypt, encryptor, CryptoStreamMode.Write);
                using (StreamWriter swEncrypt = new(csEncrypt))
                {
                    swEncrypt.Write(plainText);
                }
                encrypted = msEncrypt.ToArray();
            }
            return Convert.ToBase64String(encrypted);
        }

        public static string Decrypt(string cipherText)
        {
            string plaintext = null;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Convert.FromBase64String(_secretKey);
                aes.IV = Convert.FromBase64String(_IV);

                var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using MemoryStream msDecrypt = new(Convert.FromBase64String(cipherText));
                using CryptoStream csDecrypt = new(msDecrypt, decryptor, CryptoStreamMode.Read);
                using StreamReader srDecrypt = new(csDecrypt);
                plaintext = srDecrypt.ReadToEnd();
            }
            return plaintext;
        }
    }
}
