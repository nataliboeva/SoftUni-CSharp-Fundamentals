namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            TopNumber(num);
        }
        static void TopNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                int isOdd = 0;
                string toString = i.ToString();
                for (int j = 0; j < toString.Length; j++)
                {
                    int digits = toString[j];
                    if (digits % 2 == 1)
                    {
                        isOdd++;
                    }
                    sum += digits;
                }
                if (sum % 8 == 0 && isOdd > 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}