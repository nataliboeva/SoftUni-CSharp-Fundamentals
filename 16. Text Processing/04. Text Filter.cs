namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] banned = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach(var ban in banned)
            {
                text = text.Replace(ban, new string('*', ban.Length));
            }
            Console.WriteLine(text);
        }
    }
}
