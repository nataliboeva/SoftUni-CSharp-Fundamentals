using System.Text;

namespace _05._Teamwork_Projects
{
/*
John-PowerPuffsCoders
Tony-Tony is the best
Peter->PowerPuffsCoders
Tony->Tony is the best
end of assignment
*/
    public class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Teams> teams = new List<Teams>();
            for (int i = 0; i < count; i++)
            {
                string[] information = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                
                string user = information[0];
                string teamName = information[1];

                if(teams.Any(x => x.Team == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if(teams.Any(x => x.Creator == user))
                {
                    Console.WriteLine($"{user} cannot create another team!");
                    continue;
                }

                Teams currentTeam = new Teams(teamName, user);
                teams.Add(currentTeam);
                Console.WriteLine($"Team {teamName} has been created by {user}!");
            }

            string input;
            while((input = Console.ReadLine()) != "end of assignment")
            {
                string[] newUser = input
                    .Split("->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string teamMember = newUser[0];
                string teamName = newUser[1];

                Teams team = teams.FirstOrDefault(x => x.Team == teamName);
                if(team == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }
                if (team.Creator == teamMember || teams.SelectMany(x => x.Members).Contains(teamMember))
                {
                    Console.WriteLine($"Member {teamMember} cannot join team {teamName}!");
                    continue;
                }

                team.Members.Add(teamMember);
            }

            List<Teams> orderedTeamsByMembersCountAndName = teams
                .Where(x => x.Members.Count != 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.Team)
                .ToList();

            List<Teams> disbandTeams = teams
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.Team)
                .ToList();

            foreach(Teams team in orderedTeamsByMembersCountAndName)
            {
                Console.WriteLine(team);
            }

            Console.WriteLine("Teams to disband:");
            foreach (Teams team in disbandTeams)
            {
                Console.WriteLine(team.Team);
            }
        }
    }
    class Teams
    {
        public string Creator {  get; set; }
        public string Team { get; set; }
        public List<string> Members { get; set; } = new List<string>();
        public Teams(string team, string creator)
        {
            Team = team;
            Creator = creator;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Team);
            sb.AppendLine($"- {Creator}");

            List<string> orderedMembers = Members
                .OrderBy(x => x)
                .ToList();

            foreach (var member in orderedMembers)
            {
                sb.AppendLine($"-- {member}");
            }
            return sb.ToString().TrimEnd('\n');
        }
    }
}
