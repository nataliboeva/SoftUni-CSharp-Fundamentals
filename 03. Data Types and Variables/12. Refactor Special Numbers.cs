namespace Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)

            {

                int currentNumber = i;
                int sum = 0;

                while (currentNumber > 0)

                {
                    sum += currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }

                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
