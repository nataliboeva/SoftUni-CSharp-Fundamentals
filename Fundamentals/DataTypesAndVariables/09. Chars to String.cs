namespace Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());
            char symbol3 = char.Parse(Console.ReadLine());

            Console.WriteLine(symbol1.ToString() + symbol2.ToString() + symbol3.ToString());
        }
    }
}
