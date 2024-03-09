namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] first = new int [lines];
            int[] second = new int [lines];

            for (int i = 0; i < lines; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    first[i] = numbers[0];
                    second[i] = numbers[1];
                }
                else
                {
                    first[i] = numbers[1];
                    second[i] = numbers[0];
                }
            }
            Console.WriteLine(string.Join(" ", first));
            Console.WriteLine(string.Join(" ", second));
        }
    }
}
