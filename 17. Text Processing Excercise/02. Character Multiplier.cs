namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            int max = Math.Max(input[0].Length, input[1].Length);
            int result = 0;
            for (int i = 0; i < max; i++)
            {
                int multiplier1 = 1, multiplier2 = 1;
                if(i < input[0].Length) multiplier1 = input[0][i];
                if(i < input[1].Length) multiplier2 = input[1][i];
                result += multiplier1 * multiplier2;
            }
            Console.WriteLine(result);
        }
    }
}
