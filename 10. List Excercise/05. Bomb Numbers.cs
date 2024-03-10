using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> specialBomb = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            
            int specialNumber = specialBomb[0];
            int power = specialBomb[1];
            while (numbers.Contains(specialNumber))
            {
                int index = numbers.IndexOf(specialNumber);
                int indexLeft = Math.Max(0, index - power);
                int indexRight = Math.Min(numbers.Count - 1, index + power);

                int range = indexRight - indexLeft + 1;
                numbers.RemoveRange(indexLeft, range);

            }
            Console.WriteLine(numbers.Sum());

        }
    }
}
