namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int numCopy = num;
            int sum = 0;

            while (numCopy > 0)
            {
                //num = 145
                int digit = numCopy % 10; //5
                numCopy = numCopy / 10;

                int factorial = 1;
                for (int i = 1; i <= digit; i++)
                {
                    factorial *= i;
                }

                sum += factorial;
            }

            //if (num == sum) 
            // {
            //     Console.WriteLine("yes");
            // }
            // else
            // {
            //     Console.WriteLine("no");
            // }
            string steli = num == sum ? "yes" : "no";
            Console.WriteLine(steli);
        }
    }
}