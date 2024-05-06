using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BreachBox
{
    internal class PasswordValidator
    {
        public static bool checkKey(String input) {
            // Ch3ckm@t3!
            String password = "Ch3ckm@t3!";
            return password.Equals(input);
        }

        public static bool secureCheckKey(String input)
        {
            // ByteMeUp!256
            string password = "OTgxMzI3ODnpVGlEssEGYvDjavBt0CXI64X+T7ag+VQxSsZgEHxTmw==";
            String hashedPassword = HashPassword(input, Encoding.UTF8.GetBytes("98132789"));
            return password.Equals(hashedPassword);
        }

        static string HashPassword(string password, byte[] salt)
        {
            using (var sha256 = new SHA256Managed())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] saltedPassword = new byte[passwordBytes.Length + salt.Length];

                // Concatenate password and salt
                Buffer.BlockCopy(passwordBytes, 0, saltedPassword, 0, passwordBytes.Length);
                Buffer.BlockCopy(salt, 0, saltedPassword, passwordBytes.Length, salt.Length);

                // Hash the concatenated password and salt
                byte[] hashedBytes = sha256.ComputeHash(saltedPassword);

                // Concatenate the salt and hashed password for storage
                byte[] hashedPasswordWithSalt = new byte[hashedBytes.Length + salt.Length];
                Buffer.BlockCopy(salt, 0, hashedPasswordWithSalt, 0, salt.Length);
                Buffer.BlockCopy(hashedBytes, 0, hashedPasswordWithSalt, salt.Length, hashedBytes.Length);

                return Convert.ToBase64String(hashedPasswordWithSalt);
            }
        }
    }
}
