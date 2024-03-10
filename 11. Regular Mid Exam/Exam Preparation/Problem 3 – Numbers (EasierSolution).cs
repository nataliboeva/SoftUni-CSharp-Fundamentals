namespace Problem_3___Numbers__EasierSolution_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            double average = numbers.Average();
            List<int> topFive = numbers.FindAll(n => n > average)
                .OrderByDescending(n => n).Take(5).ToList();

            Console.WriteLine(topFive.Count == 0 ? "No" : string.Join(" ", topFive));
        }
    }
}
