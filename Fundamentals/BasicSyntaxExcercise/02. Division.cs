﻿namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if(n % 10 == 0)
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else if(n % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if(n % 6 == 0)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (n % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if (n % 2 == 0)
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
            }
        }
    }