namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] output = new int[wagons];
            int sum = 0;
            for (int i = 0; i < wagons; i++)
            {
                 int numbers = int.Parse(Console.ReadLine());
                output[i] = numbers;
                sum += numbers;
            }
            Console.WriteLine(string.Join(" ", output));
            Console.WriteLine(sum);
        }
    }
}
