using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Event_planner
{
    public static class Methods
    {
        public static string ComputeHash(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private static string GenrateConfCode()
        {
            Random random = new Random();
            string s = "" + random.Next(100000, 999999);
            return s;
        }

        public static string getConfcode()
        {
            return GenrateConfCode();
        }

        public static bool VerifyPassword(string password)
        {
            bool letters = VerifyLetter(password);
            bool s = VerifySymbol(password);
            bool d = Verifydigit(password);
            return letters && s && d;
        }

        public static bool Verifydigit(string password)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (password.Contains(i.ToString()))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool VerifyEmail(string m)
        {
            if (m.EndsWith("@gmail.com") && m.IndexOf('@') == m.LastIndexOf('@') && m.IndexOf(' ') == m.IndexOf('_'))
            {
                return true;
            }
            return false;
        }
        public static bool VerifyphoneNumber(string phonenumber)
        {
            string n = "";
            foreach (char c in phonenumber)
            {
                if (Verifydigit(c.ToString()))
                {
                    n += c;
                }
            }

            if (n.Length != 7 && n.Length != 8)
            {
                return false;
            }
            return true;
        }

        public static bool VerifySymbol(string password)
        {
            string s = "!@#$%^&*.()_";

            for (int i = 0; i < password.Length; i++)
            {
                if (s.Contains(password[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool VerifyLetter(string password)
        {
            return VerifyLowerLetter(password) && VerifyUpperLetter(password);
        }

        public static bool VerifyUpperLetter(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 'A' && password[i] <= 'Z')
                {
                    return true;
                }
            }
            return false;
        }

        public static bool VerifyLowerLetter(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 'a' && password[i] <= 'z')
                {
                    return true;
                }
            }
            return false;
        }
    }
}
