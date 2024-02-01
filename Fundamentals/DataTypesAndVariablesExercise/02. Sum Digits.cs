namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double sum = 0;
            
            while (number > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }
            Console.WriteLine(sum);
        }
    }
}
