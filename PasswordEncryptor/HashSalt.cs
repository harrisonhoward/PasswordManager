using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PasswordEncryptor {
    public class HashSalt {
        /// <summary>
        /// String to HashSalt.
        /// 
        /// Reference: https://stackoverflow.com/questions/4181198/how-to-hash-a-password/10402129#10402129
        /// </summary>
        /// <param name="password">Provided password</param>
        /// <returns>A string containing the hash salt</returns>
        public static string StringtoHashSalt(string password) {
            // Create a variable for the salt
            byte[] salt;
            // Assign a Cryptographic PRNG to our salt
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            // Create a new Rfc2898DeriveBytes
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            // Assign the pbkdf2 hash value
            byte[] hash = pbkdf2.GetBytes(20);

            // Create and store the salt and password bytes
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            // Combining the salt and hash to a string
            return Convert.ToBase64String(hashBytes);
        }

        /// <summary>
        /// Comparing Input to Password
        /// </summary>
        /// <param name="userInput">User's Input</param>
        /// <param name="password">Provided Password</param>
        /// <returns>Bool for checking if input equals password</returns>
        public static bool CompareInputtoPassword(string userInput, string password) {
            // Create a variable for comparing
            bool isEqual = false;

            // Converting the password to a hash
            byte[] hashBytes = Convert.FromBase64String(password);

            // Getting the salt and assign it
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            // Convert userInput to a hash
            var pbkdf2 = new Rfc2898DeriveBytes(userInput, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            // Comparing
            for (int i = 0; i < 20; i++) {
                if (hashBytes[i+16] == hash[i]) {
                    isEqual = true;
                }
            }

            // Return isEqual
            return isEqual;
        }
    }
}
