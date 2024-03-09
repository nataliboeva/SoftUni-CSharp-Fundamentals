using System.ComponentModel;

namespace _02._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            Grade(grade);

        }
        static void Grade(double number)
        {
            if(number >= 2.00 && number <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if(number >= 3.00 && number <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (number >= 3.50 && number <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (number >= 4.50 && number <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (number >= 5.50 && number <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
