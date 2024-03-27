using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359( |-)2\1\d{3}\1\d{4}(?!\d)";
            string input = Console.ReadLine();

            var match = Regex.Matches(input, pattern);

            Console.WriteLine(string.Join(", ", match.Select(x => x.Groups[0])));
        }
    }
}
