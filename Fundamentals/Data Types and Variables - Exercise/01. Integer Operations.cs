namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            double result = num2 += num1;
            result = Math.Round(result/num3);
            result = result*num4;

            Console.WriteLine(result);
        }
    }
}
