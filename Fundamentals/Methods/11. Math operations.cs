namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            char operatorType = char.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int sum = Math(one,operatorType,two);
            Console.WriteLine(sum);
        }
        static int Math(int first, char type, int second)
        {
            int sum = 0;
            if (type == '+') 
            {
                sum = first + second;
            }
            else if (type == '*')
            {
                sum = first * second;
            }
            else if(type == '/')
            {
                sum = first / second;
            }
            else if (type == '-')
            {
                sum = first - second;
            }
            return sum;
        }
    }
}
