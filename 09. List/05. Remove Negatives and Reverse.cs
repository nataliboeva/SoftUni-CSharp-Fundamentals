namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            List<int> positive = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= 0)
                {
                    positive.Add(numbers[i]);
                }
            }
            if (numbers.All (x => x < 0))
            {
                Console.WriteLine("empty");
                return;
            }
            positive.Reverse();
            Console.WriteLine(string.Join(" ", positive));
        }
    }
}
