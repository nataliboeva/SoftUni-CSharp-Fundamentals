namespace Problem_3___Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            double average = numbers.Average();

            List<int> topFive = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > average)
                {
                    topFive.Add(numbers[i]);           
                }
            }
            
            topFive.Sort();
            topFive.Reverse();
            if(topFive.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                int count = Math.Min(5, topFive.Count);
                for (int i = 0;i < count; i++)
                {
                    Console.Write(topFive[i] + " ");
                }
            }
        }
    }
}
