namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int result = AddAndSubtract(first, second, third);
            Console.WriteLine(result);
        }
        static int AddAndSubtract(int a, int b, int c)
        {
            int result = a + b;
            return result - c;
        }
    }
}
