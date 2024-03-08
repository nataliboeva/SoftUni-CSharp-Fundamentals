namespace _05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int from = int.Parse(Console.ReadLine());
            int to = int.Parse(Console.ReadLine());
            for (int i = from; i <= to; i++)
            {
                char symbol = (char)i;
                Console.Write(symbol + " ");
            }
        }
    }
}
