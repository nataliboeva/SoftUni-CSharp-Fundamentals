namespace _02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            int[] reverse = new int[orders];
            for (int i = 0; i < orders; i++)
            {
                int number = int.Parse(Console.ReadLine());
                reverse[i] = number;
            }
            for (int i = reverse.Length - 1; i >= 0; i--)
            {
                Console.Write(reverse[i] + " ");
            }
        }
    }
}
