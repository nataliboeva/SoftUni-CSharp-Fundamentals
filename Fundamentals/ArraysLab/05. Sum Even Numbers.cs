using System.Collections.Immutable;

namespace _05._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int check = input[i];
                if (check % 2 == 0)
                {
                    sum += input[i];
                }

            }
            Console.WriteLine(sum);
        }
    }
}
