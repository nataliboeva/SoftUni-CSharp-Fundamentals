namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = int.Parse(Console.ReadLine());
            if (i <= 10)
            {
                while (i <= 10)
                {
                    Console.WriteLine($"{n} X {i} = {n * i}");
                    i++;
                }
            }
            else
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
            }
        }
    }
}
