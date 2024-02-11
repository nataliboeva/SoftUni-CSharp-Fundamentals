namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int bestCount = 0;
            string bestCountSymbol = "";
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int count = 1;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                        if (bestCount <= count)
                        {
                            bestCount = count;
                            bestCountSymbol = numbers[i];
                        }
                    }
                    else
                    {
                        break;
                    }
                }

            }
            for (int i = 0; i < bestCount; i++)
            {
                Console.Write(bestCountSymbol + " ");
            }
        }
    }
}
