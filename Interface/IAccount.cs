using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Interface
{
    interface IAccount
    {
       bool PasswordChecker(string password);
        void ShowInfo();
    }
    public class User : IAccount
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public bool PasswordChecker(string password)
        {

            if (password.Length < 8) return false;

            bool hasLower = false;
            bool hasUpper = false;
            bool hasDigit = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i])) hasLower = true;
                if (char.IsUpper(password[i])) hasUpper = true;
                if (char.IsDigit(password[i])) hasDigit = true;
                if (hasLower && hasUpper && hasDigit) return true;
            }
            return false;

        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id{Id}");
            Console.WriteLine($"Fullname:{FullName}");
            Console.WriteLine($"Email{Email}");

        }
    }
    
}
