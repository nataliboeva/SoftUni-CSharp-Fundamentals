namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string[] day =
                {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
                };

            if (days < 1 || days > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(day [days-1]);
            }
        }
    }
}
