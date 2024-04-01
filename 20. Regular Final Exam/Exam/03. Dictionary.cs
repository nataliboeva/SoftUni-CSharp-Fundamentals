namespace _03._Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> definition = input.Split(" | ").ToList();
            Dictionary<string, List<string>> wordDefinitions = new Dictionary<string, List<string>>();

            foreach (var item in definition)
            {
                string[] pair = item.Split(": ");
                string word = pair[0];
                string def = pair[1];

                if (wordDefinitions.ContainsKey(word))
                {
                    wordDefinitions[word].Add(def);
                }
                else
                {
                    wordDefinitions[word] = new List<string>() { def };
                }
            }
            string[] wordTest = Console.ReadLine().Split(" | ");
            string command = Console.ReadLine();
            if (command == "Test")
            {
                foreach (string word in wordTest)
                {
                    if (wordDefinitions.ContainsKey(word))
                    {
                        Console.WriteLine($"{word}:");
                        foreach (string def in wordDefinitions[word])
                        {
                            Console.WriteLine($" -{def}");
                        }
                    }
                }
            }
            else if (command == "Hand Over")
            {
                Console.WriteLine(string.Join(" ", wordDefinitions.Keys));
            }

        }
    }
}