using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;


namespace PokepayPartnerCsharpSdk
{
    // tips from https://qiita.com/rawr/items/9492e7fc93be7ca99ac1

    class X509FromPemFile
    {
        public static X509Certificate2 CreateFromPemFile(string certPem, string rsaKeyPem)
        {
            byte[] certBuffer = GetBytesFromPEM(File.ReadAllText(certPem), "-----BEGIN CERTIFICATE-----", "-----END CERTIFICATE-----");
            X509Certificate2 cert = new X509Certificate2(certBuffer);

            RSACryptoServiceProvider prov = new RSACryptoServiceProvider();
            byte[] keyBuffer = GetBytesFromPEM(File.ReadAllText(rsaKeyPem), "-----BEGIN RSA PRIVATE KEY-----", "-----END RSA PRIVATE KEY-----");
            prov.ImportParameters(CreateParameter(keyBuffer));

            return cert.CopyWithPrivateKey(prov);
        }

        private static byte[] GetBytesFromPEM(string pemString, string header, string footer)
        {
            if(pemString.Length == 0)
            {
                throw new ArgumentException("pemString is empty");
            }
            int start = pemString.IndexOf(header);
            if (start < 0)
            {
                throw new ArgumentException("missing begin marker: " + header);
            }
            int end = pemString.IndexOf(footer, start + header.Length);
            if (end < 0)
            {
                throw new ArgumentException("missing end marker: " + footer);
            }
            string str = pemString.Substring(start + header.Length, end - start - header.Length);
            return Convert.FromBase64String(str);
        }

        private static byte[] Read(BinaryReader reader)
        {
            // tag
            reader.ReadByte();

            // length
            int length = 0;
            byte b = reader.ReadByte();
            if ((b & 0x80) == 0x80) // length が128 octet以上
            {
                int n = b & 0x7F;
                byte[] buf = new byte[] { 0x00, 0x00, 0x00, 0x00 };
                for (var i = n - 1; i >= 0; --i)
                    buf[i] = reader.ReadByte();
                length = BitConverter.ToInt32(buf, 0);
            }
            else // length が 127 octet以下
            {
                length = b;
            }

            // value
            if (length == 0)
                return new byte[0];
            byte first = reader.ReadByte();
            if (first == 0x00)
                length -= 1; // 最上位byteが0x00の場合は、除いておく
            else
                reader.BaseStream.Seek(-1, SeekOrigin.Current); // 1byte 読んじゃったので、streamの位置を戻しておく
            return reader.ReadBytes(length);
        }

        private static RSAParameters CreateParameter(byte[] der)
        {
            BinaryReader reader1 = new BinaryReader(new MemoryStream(der));
            byte[] sequence = Read(reader1);
            reader1.Close();

            RSAParameters parameters = new RSAParameters();
            BinaryReader reader2 = new BinaryReader(new MemoryStream(sequence));
            Read(reader2); // version
            parameters.Modulus = Read(reader2);
            parameters.Exponent = Read(reader2);
            parameters.D = Read(reader2);
            parameters.P = Read(reader2);
            parameters.Q = Read(reader2);
            parameters.DP = Read(reader2);
            parameters.DQ = Read(reader2);
            parameters.InverseQ = Read(reader2);
            reader2.Close();

            return parameters;
        }
    }
}
