namespace _07._Repeat_String
{
    internal class Program
    {
        static void PrintStringNTimes(string text, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.Write(text);
            }
        }
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            int NTimes = int.Parse(Console.ReadLine());
            PrintStringNTimes(inputText, NTimes);
        }
    }
}
