namespace _07._Theatre_Promotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string TypeDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            if (TypeDay == "Weekday")
            {
                if (age >= 0 & age <= 18)
                {
                    Console.WriteLine("12$");
                }
                else if (age > 18 & age <= 64)
                {
                    Console.WriteLine("18$");
                }
                else if (age > 64 & age <= 122)
                {
                    Console.WriteLine("12$");
                }
            }
            else if (TypeDay == "Weekend")
            {
                if (age >= 0 & age <= 18)
                {
                    Console.WriteLine("15$");
                }
                else if (age > 18 & age <= 64)
                {
                    Console.WriteLine("20$");
                }
                else if (age > 64 & age <= 122)
                {
                    Console.WriteLine("15$");
                }
            }
            else if (TypeDay == "Holiday")
            {
                if (age >= 0 & age <= 18)
                {
                    Console.WriteLine("5$");
                }
                else if (age > 18 & age <= 64)
                {
                    Console.WriteLine("12$");
                }
                else if (age > 64 & age <= 122)
                {
                    Console.WriteLine("10$");
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
