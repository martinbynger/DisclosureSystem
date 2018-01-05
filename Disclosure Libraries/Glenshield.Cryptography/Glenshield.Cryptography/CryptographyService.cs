using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Glenshield.Cryptography
{
    public static class CryptographyService
    {

        public static string Encrypt(string dataToEncrypt)
        {
            byte[] dataToEncryptAsBytes = UnicodeEncoding.Unicode.GetBytes(dataToEncrypt);

            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UnicodeEncoding.Unicode.GetBytes(MakeDynamicCertificate()));

                using (TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider()
                {
                    Key = keys,
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                })
                {
                    ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateEncryptor();
                    byte[] encryptedData = cryptoTransform.TransformFinalBlock(dataToEncryptAsBytes, 0, dataToEncryptAsBytes.Length);

                    return Convert.ToBase64String(encryptedData, 0, encryptedData.Length);
                }

            }
        }

        public static string Decrypt(string dataToDecrypt)
        {
            byte[] dataToDencryptAsBytes = Convert.FromBase64String(dataToDecrypt);

            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UnicodeEncoding.Unicode.GetBytes(MakeDynamicCertificate()));

                using (TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider()
                {
                    Key = keys,
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                })
                {
                    ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
                    byte[] decryptedData = cryptoTransform.TransformFinalBlock(dataToDencryptAsBytes, 0, dataToDencryptAsBytes.Length);

                    return UnicodeEncoding.Unicode.GetString(decryptedData);
                }

            }
        }

        public static string MakeDynamicCertificate()
        {
            string CertificateBase = "FHJ(/&%¤REfvD23yNMK)7hBT¤";
            int DynamicPartOfCertificate = (DateTime.Now.Day * 3);
            return DynamicPartOfCertificate.ToString() + CertificateBase;
        }
    }
}
