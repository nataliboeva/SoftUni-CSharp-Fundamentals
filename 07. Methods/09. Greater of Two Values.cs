namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void GetMax(string type)
        {
            if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                if (a > b)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(b);
                }
            }
            else if (type == "char")
            {
                char one = char.Parse(Console.ReadLine());
                char two = char.Parse(Console.ReadLine());
                if (one > two)
                {
                    Console.WriteLine(one);
                }
                else
                {
                    Console.WriteLine(two);
                }

            }
            else if(type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                int command = first.CompareTo(second);
                if(command > 0)
                {
                    Console.WriteLine(first);
                }
                else
                {
                    Console.WriteLine(second);
                }
            }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            GetMax(input);
        }
    }
}
