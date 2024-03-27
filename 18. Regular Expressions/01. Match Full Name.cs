using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            string input = Console.ReadLine();

            var match = Regex.Matches(input, pattern);

            Console.WriteLine(string.Join(" ", match.Select(x => x.Groups[0])));
        }
    }
}
