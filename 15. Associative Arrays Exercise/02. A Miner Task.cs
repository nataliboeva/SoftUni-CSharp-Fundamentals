namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, int> map = new Dictionary<string, int>();
            while((input = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!map.ContainsKey(input))
                {
                    map.Add(input, quantity);
                }
                else
                {
                    map[input] += quantity;
                }
            }
            foreach (var kvp in map)
            {
                Console.WriteLine(kvp.Key + " -> " + kvp.Value);
            }
        }
    }
}
