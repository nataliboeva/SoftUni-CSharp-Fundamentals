using System.Text.RegularExpressions;
using System.Text;

namespace _01._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            StringBuilder sb = new StringBuilder(password);

            string input;
            while ((input = Console.ReadLine()) != "Complete")
            {
                string[] token = input.Split();
                string command = token[0];
                if (command == "Make")
                {
                    string direction = token[1];
                    int index = int.Parse(token[2]);
                    if (IsValidIndex(index, sb.Length - 1))
                    {
                        if (direction == "Upper")
                            sb[index] = char.ToUpper(sb[index]);
                        else if (direction == "Lower")
                            sb[index] = char.ToLower(sb[index]);
                        Console.WriteLine(sb);
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(token[1]);
                    char ch = char.Parse(token[2]);
                    if (IsValidIndex(index, sb.Length))
                    {
                        sb.Insert(index, ch);
                        Console.WriteLine(sb);
                    }
                }
                else if (command == "Replace")
                {
                    char replace = char.Parse(token[1]);
                    int value = int.Parse(token[2]);
                    if (password.Contains(replace))
                    {
                        for (int i = 0; i < sb.Length; i++)
                        {
                            if (sb[i] == replace)
                            {
                                int newValue = (int)replace + value;
                                char newReplace = (char)newValue;
                                sb[i] = newReplace;
                            }
                        }
                        Console.WriteLine(sb);
                    }
                }
                else if (command == "Validation")
                {
                    PasswordValidation(sb.ToString());
                }
            }
        }

        private static bool IsValidIndex(int index, int length)
        {
            return index >= 0 && index <= length;
        }

        static void PasswordValidation(string password)
        {
            bool isValid = true;

            if (password.Length < 8)
            {
                Console.WriteLine("Password must be at least 8 characters long!");
                isValid = false;
            }

            if (!Regex.IsMatch(password, @"^[A-Za-z0-9_]+$"))
            {
                Console.WriteLine("Password must consist only of letters, digits and _!");
                isValid = false;
            }

            if (!Regex.IsMatch(password, "[A-Z]"))
            {
                Console.WriteLine("Password must consist at least one uppercase letter!");
                isValid = false;
            }

            if (!Regex.IsMatch(password, "[a-z]"))
            {
                Console.WriteLine("Password must consist at least one lowercase letter!");
                isValid = false;
            }

            if (!Regex.IsMatch(password, "[0-9]"))
            {
                Console.WriteLine("Password must consist at least one digit!");
                isValid = false;
            }

        }
    }
}
