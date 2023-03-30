using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MIB1
{
    internal static class PasswordsLogins
    {
        public static Dictionary<string, string> loginpasswords = new Dictionary<string, string>();

        public static void Init()
        {
            if (!File.Exists("lp.txt"))
            {
                File.Create("lp.txt");
            }
            else
            {
                IEnumerable<string> lines = File.ReadLines("lp.txt");
                foreach (string line in lines)
                {
                    var splitted = line.Split(new char[] { '-' });
                    loginpasswords.Add(splitted[0], splitted[1]);
                }
            }
        }

        public static void Save()
        {
            if (!File.Exists("lp.txt"))
            {
                File.Create("lp.txt");
            }
            File.WriteAllLines("lp.txt", loginpasswords.Select(x => $"{x.Key}-{x.Value}"));
        }

        public static bool Login(string login, string password)
        {
            if (login.Length == 0)
            {
                MessageBox.Show("Заполните логин");
                return false;
            }
            if (password.Length == 0)
            {
                MessageBox.Show("Заполните пароль");
                return false;
            }

            string? val;
            if (loginpasswords.TryGetValue(login, out val))
            {
                MessageBox.Show("Успешно");
                return true;
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
                return false;
            }
        }

        public static bool Registration (string login, string password)
        {
            if (login.Length == 0)
            {
                MessageBox.Show("Заполните логин");
                return false;
            }
            if (password.Length == 0)
            {
                MessageBox.Show("Заполните пароль");
                return false;
            }

            if (login.Length < 8)
            {
                MessageBox.Show($"Логин должен быть больше {8} символов!");
                return false;
            }
            if (login.Length > 32)
            {
                MessageBox.Show($"Логин должен быть меньше {32} символов!");
                return false;
            }

            var forbiddenSymbols = new string[] { "-", "\n" };
            foreach (var forbiddenSymbol in forbiddenSymbols)
            {
                if (login.Contains(forbiddenSymbol))
                {
                    MessageBox.Show($"Логин содержит запрещенный символ {forbiddenSymbol}");
                    return false;
                }
            }

            if (loginpasswords.ContainsKey(login))
            {
                MessageBox.Show($"Логин занят");
                return false;
            }

            if (password.Length < 8)
            {
                MessageBox.Show($"Пароль должен быть больше {8} символов!");
                return false;
            }
            if (password.Length > 50)
            {
                MessageBox.Show($"Пароль должен быть меньше {32} символов!");
                return false;
            }

            var engCapsRegex = new Regex(@"([A-Z])");
            var rusCapsRegex = new Regex(@"([А-Я])");
            if (!engCapsRegex.IsMatch(password) && !rusCapsRegex.IsMatch(password))
            {
                MessageBox.Show("Пароль должен содержать прописные буквы!");
                return false;
            }

            var digitsRegex = new Regex(@"([0-9])");
            if (!digitsRegex.IsMatch(password))
            {
                MessageBox.Show("Пароль должен содержать цифры!");
                return false;
            }

            var symbolsRegex = new Regex(@"([!,@,#,$,%,^,&,*,?,_,~])");
            if (!symbolsRegex.IsMatch(password))
            {
                MessageBox.Show("Пароль должен содержать спец символы!");
                return false;
            }

            if (password.Contains('-'))
            {
                MessageBox.Show("Пароль содержит запрещенные символы!");
                return false;
            }

            loginpasswords.Add(login, password);
            Save();
            MessageBox.Show("Успешно!");
            return true;
        }

        public static bool ChangePwd (string login, string pwd1, string pwd2)
        {
            if (login.Length == 0)
            {
                MessageBox.Show("Заполните логин");
                return false;
            }
            if (pwd1.Length == 0)
            {
                MessageBox.Show("Заполните старый пароль");
                return false;
            }
            if (pwd2.Length == 0)
            {
                MessageBox.Show("Заполните новый пароль");
                return false;
            }
            if (pwd1 == pwd2)
            {
                MessageBox.Show("Пароли совпадают!");
                return false;
            }

            string? val;
            if (!loginpasswords.TryGetValue(login, out val))
            {
                MessageBox.Show("Неправильный логин или пароль");
                return false;
            }

            if (pwd2.Length < 8)
            {
                MessageBox.Show($"Пароль должен быть больше {8} символов!");
                return false;
            }
            if (pwd2.Length > 50)
            {
                MessageBox.Show($"Пароль должен быть меньше {32} символов!");
                return false;
            }

            var engCapsRegex = new Regex(@"([A-Z])");
            var rusCapsRegex = new Regex(@"([А-Я])");
            if (!engCapsRegex.IsMatch(pwd2) && !rusCapsRegex.IsMatch(pwd2))
            {
                MessageBox.Show("Пароль должен содержать прописные буквы!");
                return false;
            }

            var digitsRegex = new Regex(@"([0-9])");
            if (!digitsRegex.IsMatch(pwd2))
            {
                MessageBox.Show("Пароль должен содержать цифры!");
                return false;
            }

            var symbolsRegex = new Regex(@"([!,@,#,$,%,^,&,*,?,_,~])");
            if (!symbolsRegex.IsMatch(pwd2))
            {
                MessageBox.Show("Пароль должен содержать спец символы!");
                return false;
            }

            loginpasswords[login] = pwd2;
            Save();
            MessageBox.Show("Успешно!");
            return true;
        }
    }
}
