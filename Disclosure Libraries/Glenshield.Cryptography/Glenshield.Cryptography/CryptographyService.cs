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

        private const string EncryptedFileKey = "tn7il&/R&M;LFDSffguas78gyFV";

        public static string EncryptForNetwork(string dataToEncrypt)
        {
            return Encrypt(dataToEncrypt, MakeDynamicCertificate());
        }

        public static string DecryptFromNetwork(string dataToDecrypt)
        {
            return Decrypt(dataToDecrypt, MakeDynamicCertificate());
        }

        private static string Encrypt(string dataToEncrypt, string encryptionKey)
        {
            byte[] dataToEncryptAsBytes = UnicodeEncoding.Unicode.GetBytes(dataToEncrypt);

            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UnicodeEncoding.Unicode.GetBytes(encryptionKey));

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

        private static string Decrypt(string dataToDecrypt, string decryptionKey)
        {
            byte[] dataToDencryptAsBytes = Convert.FromBase64String(dataToDecrypt);

            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UnicodeEncoding.Unicode.GetBytes(decryptionKey));

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

        private static string MakeDynamicCertificate()
        {
            string CertificateBase = "FHJ(/&%¤REfvD23yNMK)7hBT¤";
            int DynamicPartOfCertificate = (DateTime.Now.Day * 3);
            return DynamicPartOfCertificate.ToString() + CertificateBase;
        }

        public static void WriteDeviceIDEncrypted(long deviceID)
        {
            System.IO.File.WriteAllText(@".\Resources\disclosure.ini", Encrypt(deviceID.ToString(), EncryptedFileKey));
        }

        public static long ReadDeviceIDEncrypted()
        {
            try
            {
                return long.Parse( Decrypt(System.IO.File.ReadAllText(@".\Resources\disclosure.ini"), EncryptedFileKey));
            }
            catch
            {
                return (long) 0;
            }
            
        }
    }
}
