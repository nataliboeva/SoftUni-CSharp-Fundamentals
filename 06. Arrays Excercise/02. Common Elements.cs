namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split();
            string[] second = Console.ReadLine().Split();
            string[] check = new string[first.Length + second.Length];

            for (int i = 0; i < second.Length; i++)
            {
                for (int j = 0; j < first.Length; j++)
                {
                    if (second[i] == first[j])
                    {
                        check[i] = second[i];
                        Console.Write(check[i] + " ");
                    }
                }
            }
        }
    }
}
