using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Authetication1.Models
{
    public class encrypted
    {
       public  string EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            String EncryptionKey = "MAKV2SPBNI99212";
            byte[] plainBytes = Encoding.Unicode.GetBytes(plainText);
            
            string encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                // Create an encryptor to perform the stream transform.
                aesAlg.Key = pdb.GetBytes(32);
                aesAlg.IV = pdb.GetBytes(16);
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.  
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {

                        csEncrypt.Write(plainBytes, 0, plainBytes.Length);
                        csEncrypt.Close();
                    }
                    encrypted = Convert.ToBase64String(msEncrypt.ToArray());
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

       
        public  string DecryptStringFromBytes_Aes(string cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            String EncryptionKey = "MAKV2SPBNI99212";


            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;
            cipherText = cipherText.Replace(@"""", string.Empty);
            cipherText = cipherText.Replace('-', '+');
            cipherText = cipherText.Replace('_', '/');
            cipherText = cipherText.Replace('=', '/');
            cipherText = cipherText.Replace(':', '/');
            byte[] cipherBytes = Convert.FromBase64String(cipherText);

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                // Create an encryptor to perform the stream transform.
                aesAlg.Key = pdb.GetBytes(32);
                aesAlg.IV = pdb.GetBytes(16);


                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream())
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Write))
                    {
                        csDecrypt.Write(cipherBytes, 0, cipherBytes.Length);
                        csDecrypt.Close();
                    }
                    plaintext = Encoding.Unicode.GetString(msDecrypt.ToArray());
                }
            }

            return plaintext;
        }

    }
}
