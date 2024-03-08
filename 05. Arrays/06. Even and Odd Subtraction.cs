namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < numbers.Length; i++) 
            {
                int check = numbers[i];
                if (check % 2 == 0)
                {
                    sumEven += numbers[i];
                }
                else if (check % 2 == 1)
                {
                    sumOdd += numbers[i];
                }
            }
            Console.WriteLine(sumEven - sumOdd);
        }
    }
}
