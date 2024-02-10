namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            while (rotations > 0)
            {
                int first = numbers[0];
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    numbers[i] = numbers[i + 1];
                }
                numbers[numbers.Length - 1] = first;
                rotations--;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
