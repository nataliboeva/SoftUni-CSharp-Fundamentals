using System.Text.RegularExpressions;

namespace _02._Easter_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"[@|#]+(?<color>[a-z]{3,})[@|#]+[^a-z\d]*\/+(?<amount>\d+)\/+";
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {

                Console.WriteLine($"You found {match.Groups["amount"].Value} {match.Groups["color"].Value} eggs!");
            }
        }
    }
}
