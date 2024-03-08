namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int sum = 255;
            for (int i = 1; i <= lines; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (liters > sum)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sum -= liters;
                }
            }
            Console.WriteLine(255-sum);
        }
    }
}
