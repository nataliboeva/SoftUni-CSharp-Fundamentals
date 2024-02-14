namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MiddleChar(input);
        }
        static void MiddleChar(string text)
        {
            string middle = text.Substring((text.Length /2) - 1,2);
            if (text.Length % 2 == 0)
            {
                Console.WriteLine(middle);
            }

            else
            {
                Console.WriteLine(text.Substring((text.Length / 2),1));
            }
        }
    }
}
