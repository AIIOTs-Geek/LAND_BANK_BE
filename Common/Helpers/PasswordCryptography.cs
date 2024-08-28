using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helpers
{
    public static class PasswordCryptography
    {
        private const string UppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string LowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
        private const string Digits = "0123456789";
        private const string SpecialCharacters = "!@#$%^&*()_+-=[]{}|<>?";

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            using (var sha256 = SHA256.Create())
            {

                var saltedPassword = password + "hfidowfjdjfjfuiodfshibknfvnxb567687ee9uhrfidjf{}{WDMFPFMOFMF";
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));
                var hashedInputPassword = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                return hashedInputPassword == hashedPassword;
            }
        }

        public static string hashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var saltedPassword = password + "hfidowfjdjfjfuiodfshibknfvnxb567687ee9uhrfidjf{}{WDMFPFMOFMF";
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

     



        public static string GeneratePassword(int length = 12)
        {
            string allCharacters = UppercaseLetters + LowercaseLetters + Digits + SpecialCharacters;
            var password = new StringBuilder();
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] buffer = new byte[4];
                for (int i = 0; i < length; i++)
                {
                    rng.GetBytes(buffer);
                    int index = (int)(BitConverter.ToUInt32(buffer, 0) % allCharacters.Length);
                    password.Append(allCharacters[index]);
                }
            }
            return password.ToString();
        }
    }
}
