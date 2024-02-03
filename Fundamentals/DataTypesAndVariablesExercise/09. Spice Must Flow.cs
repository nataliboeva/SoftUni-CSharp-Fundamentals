namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int daysOfOperation = 0;
            int totalAmountOfSpice = 0;
            for (int i = startingYield; i >= 100; i-=10)
            {
                totalAmountOfSpice += i - 26;
                daysOfOperation++;
            }
            if(daysOfOperation > 0)
            {
                totalAmountOfSpice -= 26;
            }
            Console.WriteLine(daysOfOperation);
            Console.WriteLine(totalAmountOfSpice);
        }
    }
}
