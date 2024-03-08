namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int round = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine(numbers[i] + " => " + round);
            }
            
        }
    }
}
