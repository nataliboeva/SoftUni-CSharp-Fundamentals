namespace Methods___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int smallest = Smallest(first, second, third);
            Console.WriteLine(smallest);
        }
        static int Smallest(int one, int two, int three)
        {
            if (one < two && one < three)
            {
                return one;
            }
            else if(two < one && two < three)
            {
                return two;
            }
            else
            {
                return three;
            }
        }
    }
}
