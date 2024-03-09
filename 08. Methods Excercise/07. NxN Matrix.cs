namespace NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Matrix(n);
        }
        static void Matrix(int num)
        {
            for (int rol = 0; rol < num; rol++)
            {
                Console.Write(num + " ");
                for (int col = 1; col < num; col++)
                {
                    Console.Write( num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
