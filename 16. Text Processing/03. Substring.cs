namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filter = Console.ReadLine();
            string word = Console.ReadLine();

            while(word.Contains(filter))
            {
                int remove = word.IndexOf(filter);
                word = word.Remove(remove, filter.Length);
            }
            Console.WriteLine(word);
        }
    }
}
