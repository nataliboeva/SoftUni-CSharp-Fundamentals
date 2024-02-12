using System;
using System.Diagnostics.CodeAnalysis;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int even = GetSumOfEvenDigits(number);
            int odd = GetSumOfOddDigits(number);
            Console.WriteLine(even * odd);
            GetSumOfEvenDigits(number);

        }
        static int GetSumOfEvenDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int currentNum = num % 10;
                num = num / 10;

                if (currentNum % 2 == 0)
                {
                    sum += currentNum;
                }
            }
                return sum;
        }
        static int GetSumOfOddDigits(int num)
        {
             int sum = 0;
             while (num > 0)
             {
                 int currentNum = num % 10;
                 num = num / 10;

                 if (currentNum % 2 == 1)
                 {
                     sum += currentNum;
                 }
             }

             return sum;
            }
        }
    }
