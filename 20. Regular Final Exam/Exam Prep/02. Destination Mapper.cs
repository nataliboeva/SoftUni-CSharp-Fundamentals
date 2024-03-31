using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(=|\/)(?<destination>[A-Z][A-Za-z]{2,})(\1)";
            string input = Console.ReadLine();
            List<string> list = new List<string>();
            int sumLenght = 0;

            foreach(Match match in Regex.Matches(input, pattern))
            {
                string result = match.Groups["destination"].Value;
                list.Add(result);
                sumLenght += result.Length;
            }

            Console.WriteLine("Destinations: " + string.Join(", ",list));
            Console.WriteLine("Travel Points: " + sumLenght);
        }
    }
}
