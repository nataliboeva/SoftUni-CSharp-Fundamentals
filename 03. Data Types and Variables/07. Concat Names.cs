﻿namespace Concat_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimiter = Console.ReadLine();
            Console.WriteLine(firstName + delimiter + secondName);
        }
    }
}
