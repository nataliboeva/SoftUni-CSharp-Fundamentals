using System.Text;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        class Participants
        {
            public Participants(string name)
            {
                Name = name;
                Distance = 0;
            }
            public string Name {  get; set; }
            public uint Distance { get; set; }
        }
        static void Main(string[] args)
        {
            Dictionary<string, Participants> participant = new Dictionary<string, Participants>();
            string[] participantNames = Console.ReadLine().Split(", ");

            for (int i = 0; i < participantNames.Length; i++)
            {
                participant.Add(participantNames[i], new Participants(participantNames[i]));

            }

            string lettersPattern = @"[A-Za-z]";
            string digitsPattern = @"\d";

            string input;
            while((input = Console.ReadLine()) != "end of race")
            {
                StringBuilder sb = new StringBuilder();
                foreach (Match match in Regex.Matches(input, lettersPattern))
                {
                    sb.Append(match.Value);
                }
                if(participant.ContainsKey(sb.ToString()))
                {
                    uint distance = 0;
                    foreach (Match match in Regex.Matches(input, digitsPattern))
                    {
                        distance += uint.Parse(match.Value);
                    }
                    participant[sb.ToString()].Distance += distance;
                }
            }
            List<Participants> winners = participant
                .Select(p => p.Value)
                .OrderByDescending(p => p.Distance)
                .Take(3)
                .ToList();
            Console.WriteLine($"1st place: {winners[0].Name}");
            Console.WriteLine($"2nd place: {winners[1].Name}");
            Console.WriteLine($"3rd place: {winners[2].Name}");
        }
    }
}
