namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();
                if (!synonyms.ContainsKey(key))
                {
                    synonyms.Add(key, new List<string>()); 
                }
                synonyms[key].Add(value);

            }
            foreach(var synonym in synonyms)
            {
                Console.WriteLine(synonym.Key + " - " + string.Join(", ", synonym.Value));
            }
            
        }
    }
}
