namespace Reversed_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            Console.Write(thirdLetter + " " + secondLetter + " " + firstLetter);
        }
    }
}
