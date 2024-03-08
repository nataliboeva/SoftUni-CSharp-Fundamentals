namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadsets = 0;
            int trashedMouses = 0;
            int trashedKeyboards = 0;
            int trashedDisplays = 0;

            for (int i = 1; i <= lostGames; i ++ )
            {
                if(i % 2 == 0)
                {
                    trashedHeadsets++;
                }
                if(i % 3 == 0)
                {
                    trashedMouses++;
                }
                if(i % 6 == 0)
                {
                    trashedKeyboards++;
                }
                if (i % 12 == 0)
                {
                    trashedDisplays++;
                }
            }
            double HeadSetExpenses = headsetPrice * trashedHeadsets;
            double MouseSetExpenses = mousePrice * trashedMouses;
            double KeyboardSetExpenses = keyboardPrice * trashedKeyboards;
            double DisplaySetExpenses = displayPrice * trashedDisplays;
            double Expenses = HeadSetExpenses + MouseSetExpenses + KeyboardSetExpenses + DisplaySetExpenses;

            Console.WriteLine($"Rage expenses: {Expenses:f2} lv.");
        }
    }
}
