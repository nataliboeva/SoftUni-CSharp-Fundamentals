using System.Runtime.InteropServices;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Factoriel(num1, num2);

        }
        static void Factoriel(int first, int second) 
        {
            double sumFirst = first;
            for (int i = 1; i < first; i++)
            {
                sumFirst *= first - i;
            }
            double sumSecond = second;
            for (int i = 1; i < second; i++)
            {
                sumSecond *= second - i;
            }
            Console.WriteLine($"{(sumFirst / sumSecond):f2}");
        }
    }
}
