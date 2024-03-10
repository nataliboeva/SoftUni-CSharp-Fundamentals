using System.Xml.Linq;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            for (int i = 0; i < n; i++)
            {
                List<string> guestsLists = Console.ReadLine()
                    .Split()
                    .ToList();
                
                if (guestsLists[2] == "going!")
                {
                    
                    if (names.Contains(guestsLists[0]))
                    {
                        Console.WriteLine($"{guestsLists[0]} is already in the list!");
                    }
                    else
                    {
                        names.Add(guestsLists[0]);
                    }
                }
                else if (guestsLists[2] == "not")
                {
                    if (names.Contains(guestsLists[0]))
                    {
                        names.Remove(guestsLists[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{guestsLists[0]} is not in the list!");
                    }
                }
            }
                Console.WriteLine(string.Join(" " + "\n", names));
        }
    }
}
