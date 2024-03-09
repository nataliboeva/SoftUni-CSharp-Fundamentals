namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            Calculations(input, first, second);
        }
        static void Calculations(string type, int number1, int number2)
        {
            int sum = 0;
            if(type == "add")
            {
                sum = number1 + number2;
            }
            else if (type == "multiply")
            {
                sum = number1 * number2;
            }
            else if(type == "subtract")
            {
                sum = number1 - number2;
            }
            else if (type == "divide")
            {
                sum = number1 / number2;
            }
            Console.WriteLine(sum);
        }
    }
}
