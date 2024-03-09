using System.Xml;

namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> one = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> two = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();
            int max = Math.Max(one.Count, two.Count);

            for (int i = 0; i < max; i++)
            {
                if(i < one.Count)
                {
                    result.Add(one[i]);
                }
                if(i < two.Count)
                {
                    result.Add(two[i]);
                }
            }
            Console.WriteLine(string.Join (" ", result));
        }
    }
}
