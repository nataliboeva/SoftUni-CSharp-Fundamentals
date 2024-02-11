namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }
                    sumLeft = 0;

                for (int left = i; left > 0; left--)
                {
                     int next = left - 1;
                     if(left > 0)
                     {
                        sumLeft += numbers[next];
                     }
                }
                    sumRight = 0; 

                for (int right = i; right < numbers.Length; right++)
                {
                    int next = right + 1;

                    if (right < numbers.Length - 1)
                    {
                       sumRight += numbers[next];
                    } 
                }

                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    return;
                }

            }
            Console.WriteLine("no");
        }
    }
}
