namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                char character = input[i];
                if(character == ' ')
                {
                    continue;
                }
                if (!map.ContainsKey(character))
                {
                    map.Add(character, 0);
                }
                map[character]++;
            }
            foreach (var c in map)
            {
                Console.WriteLine(c.Key + " -> " + c.Value);
            }
        }
    }
}
