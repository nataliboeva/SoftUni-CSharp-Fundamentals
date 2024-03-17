using System.Text;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string letters = string.Empty;
            string numbers = string.Empty;
            string others = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                char current = text[i];
                if (char.IsLetter(current))
                {
                    letters += current;
                }
                else if(char.IsDigit(current))
                {
                    numbers += current;
                }
                else
                {
                    others += current;
                }
            }

            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
