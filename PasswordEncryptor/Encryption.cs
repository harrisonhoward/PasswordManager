using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace PasswordEncryptor {
    /// <summary>
    /// Encryption and Decryption with a key
    /// 
    /// Reference: https://stackoverflow.com/questions/10168240/encrypting-decrypting-a-string-in-c-sharp
    /// </summary>
    public class Encryption {
        /*
         * keySize is used to determine the key size of the encryption algorithm in bits.
         * 
         * derivationIterations is used to determine the number of iterations for the password bytes generation
        */
        private const int keySize = 256;
        private const int derivationIterations = 1000;

        public static string Encrypt(string passwordInput, string encryptKey) {
            // Generate our salt and iv bytes
            byte[] saltStringBytes = Generate256BitsOfRandomEntropy();
            byte[] ivStringBytes = Generate256BitsOfRandomEntropy();
            // Convert our password to bytes
            byte[] passwordBytes = Encoding.UTF8.GetBytes(passwordInput);

            // Convert our encrypt key to Rfc2989DeriveBytes using our salt and derivation iterations
            // Convert that Derive Bytes encrypt key to bytes using our key size / 8
            DeriveBytes encrypt = new Rfc2898DeriveBytes(encryptKey, saltStringBytes, derivationIterations);
            byte[] keyBytes = encrypt.GetBytes(keySize / 8);

            // Create a new instance of the RijndaelManaged class
            RijndaelManaged symmetricKey = new RijndaelManaged();
            // Set the block of the cryptographic operation
            symmetricKey.BlockSize = 256;
            // Set the mode operation for the symmetric algorithm
            symmetricKey.Mode = CipherMode.CBC;
            // Set the padding used in the symmetic algorithm
            symmetricKey.Padding = PaddingMode.PKCS7;

            // Create a Encryption Object with the key bytes and iv
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes);
            // Create a new instance of Memory Stream
            MemoryStream memoryStream = new MemoryStream();

            // Create a new instance of crypto stream using the memory stream, encryptor and Crypto Stream Mode Write
            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            // Write our username bytes to the crypto stream
            cryptoStream.Write(passwordBytes, 0, passwordInput.Length);
            // Update the data source with the current buffer and then clear the buffer
            cryptoStream.FlushFinalBlock();

            // Create the final bytes as a concatenation of the random salt bytes, the random iv bytes and the cipher bytes.
            byte[] cipherTextBytes = saltStringBytes;
            // Concatenate iv bytes and the memory stream
            cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
            cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
            // Close the memory stream and crypto stream
            memoryStream.Close();
            cryptoStream.Close();
            // Return our encryption as a string
            return Convert.ToBase64String(cipherTextBytes);
        }

        public static string Decrypt(string passwordEncrypted, string encryptKey) {
            // Get the complete stream of bytes that represent:
            // [32 bytes of Salt] + [32 bytes of IV] + [n bytes of CipherText]
            byte[] passwordEncryptedBytesSaltIV = Convert.FromBase64String(passwordEncrypted);
            // Get the saltbytes by extracting the first 32 bytes from the supplied passwordInput bytes.
            byte[] saltStringBytes = passwordEncryptedBytesSaltIV.Take(keySize / 8).ToArray();
            // Get the IV bytes by extracting the next 32 bytes from the supplied passwordEncrypted bytes.
            byte[] ivStringBytes = passwordEncryptedBytesSaltIV.Skip(keySize / 8).Take(keySize / 8).ToArray();
            // Get the actual passwordEncrypted bytes by removing the first 64 bytes from the passwordEncrypted string.
            byte[] passwordEncryptedBytes = passwordEncryptedBytesSaltIV.Skip((keySize / 8) * 2).Take(passwordEncryptedBytesSaltIV.Length - ((keySize / 8) * 2)).ToArray();

            // Convert our encrypt key to Rfc2989DeriveBytes using our salt and derivation iterations
            // Convert that Derive Bytes encrypt key to bytes using our key size / 8
            DeriveBytes encrypt = new Rfc2898DeriveBytes(encryptKey, saltStringBytes, derivationIterations);
            byte[] keyBytes = encrypt.GetBytes(keySize / 8);

            // Create a new instance of the RijndaelManaged class
            RijndaelManaged symmetricKey = new RijndaelManaged();
            // Set the block of the cryptographic operation
            symmetricKey.BlockSize = 256;
            // Set the mode operation for the symmetric algorithm
            symmetricKey.Mode = CipherMode.CBC;
            // Set the padding used in the symmetic algorithm
            symmetricKey.Padding = PaddingMode.PKCS7;

            // Create a Decryption Object with the key bytes and iv
            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes);
            // Create a new instance of Memory Stream
            MemoryStream memoryStream = new MemoryStream(passwordEncryptedBytes);

            // Create a new instance of crypto stream using the memory stream, decryptor and Crypto Stream Mode Read
            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            // Create a byte array using the password bytes length as the size
            byte[] passwordBytes = new byte[passwordEncryptedBytes.Length];
            // Create an variable getting the count of the decrypt
            int decryptedByteCount = cryptoStream.Read(passwordBytes, 0, passwordBytes.Length);

            // Close the memory and crypt stream
            memoryStream.Close();
            cryptoStream.Close();
            // Return the decrypted password as a string
            return Encoding.UTF8.GetString(passwordBytes, 0, decryptedByteCount);
        }

        private static byte[] Generate256BitsOfRandomEntropy() {
            // 32 Bytes will give us 256 bits.
            var randomBytes = new byte[32];
            using (var rngCsp = new RNGCryptoServiceProvider()) {
                // Fill the array with cryptographically secure random bytes.
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }
    }
}
