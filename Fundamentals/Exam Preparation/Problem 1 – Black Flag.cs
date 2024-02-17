namespace Problem_1___Black_Flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int daily = int.Parse(Console.ReadLine());
            double expected = double.Parse(Console.ReadLine());

            double total = 0;

            for (int i = 1; i <= days; i++)
            {
                total += daily;

                if(i % 3 == 0)
                {
                    total += daily * 0.5;
                }
                if(i % 5 == 0)
                {
                    total *=  0.7;
                }
            }

            if(total>= expected)
            {
                Console.WriteLine($"Ahoy! {total:f2} plunder gained.")
;           }
            else
            {
                var percentage = total / expected * 100; 
                Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
            }
        }
    }
}
