using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<date>\d{2})(?<seperator>\.|\-|\/)(?<month>[A-Z][a-z]{2})(\k<seperator>)(?<year>\d{4})";
            string input = Console.ReadLine();

            var matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["date"].Value}, Month: {match.Groups["month"].Value}, Year: {match.Groups["year"].Value}");
            }
        }
    }
}
