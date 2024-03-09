namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());
            BetweenSymbols(symbol1,symbol2);
        }
        static void BetweenSymbols(char one, char two)
        {
            if(two > one)
            {
                for (int i = one + 1; i < two; i++)
                {
                    Console.Write(((char)i) + " ");
                }
            }
            else
            {
                for (int i = two + 1; i < one; i++)
                {
                    Console.Write(((char)i) + " ");
                }
            }
        }
    }
}
