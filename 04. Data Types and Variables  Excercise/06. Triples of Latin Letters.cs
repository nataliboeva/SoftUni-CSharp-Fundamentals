namespace _06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int startChar = 97;
            int endChar = startChar + count;

            for (int i = startChar; i < endChar; i++)
            {
                for (int j = startChar; j < endChar; j++)
                {
                    for (int k = startChar; k < endChar; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }
            }
        }
    }
}
