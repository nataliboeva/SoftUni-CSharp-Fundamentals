﻿namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = num1; i <= num2; i++)
            {
                sum += i;
                Console.Write(i + " ");
            }
            Console.WriteLine($"\nSum: {sum}");
        }
    }
}
