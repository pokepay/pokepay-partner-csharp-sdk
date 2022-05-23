using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System;
using System.IO;
using System.Linq;

namespace PokepayPartnerCsharpSdk
{
    public class Encrypter
    {
        static readonly char[] base64Padding = { '=' };

        public static string EncodeBase64Url(byte[] toEncode)
        {
            return System.Convert.ToBase64String(toEncode)
                .TrimEnd(base64Padding).Replace('+', '-').Replace('/', '_');
        }

        public static byte[] DecodeBase64Url(string toDecode)
        {
            string base64 = toDecode.Replace('_', '/').Replace('-', '+');
            switch(toDecode.Length % 4) {
            case 2: {
                base64 += base64Padding[0];
                base64 += base64Padding[0];
                break;
            }
            case 3: base64 += base64Padding[0]; break;
            }
            return Convert.FromBase64String(base64);
        }

        public static string EncryptData(string plainText, byte[] key)
        {
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (key == null || key.Length <= 0)
                throw new ArgumentNullException("key");
            plainText = "0000000000000000" + plainText;
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        return Encrypter.EncodeBase64Url(msEncrypt.ToArray());
                    }
                }
            }
        }

        public static string DecryptData(string cipherText, byte[] key)
        {
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (key == null || key.Length <= 0)
                throw new ArgumentNullException("key");
            byte[] cipherByte = Encrypter.DecodeBase64Url(cipherText);
            byte[] iv = cipherByte.Take(16).ToArray();
            cipherByte = cipherByte.Skip(16).ToArray();
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msDecrypt = new MemoryStream(cipherByte))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
