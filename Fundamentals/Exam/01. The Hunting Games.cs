namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int numberOfPlayers = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterPerDayForOne = double.Parse(Console.ReadLine());
            double foodPerDayForOne = double.Parse(Console.ReadLine());

            double totalWater = days * numberOfPlayers * waterPerDayForOne;
            double totalFood = days * numberOfPlayers * foodPerDayForOne;
            double energy = groupEnergy;
            for (int i = 1; i <= days; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                energy -= energyLoss;
                if (energy <= 0)
                {
                    break;
                }
                if(i % 2 == 0)
                {
                    totalWater *= 0.7;
                    energy = energy + (energy * 0.05); 
                }
                if(i % 3 == 0)
                {
                    totalFood = totalFood - (totalFood / numberOfPlayers);
                    energy = energy + (energy * 0.1);
                }
            }
            if(energy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy:f2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
            }
        }
    }
}
