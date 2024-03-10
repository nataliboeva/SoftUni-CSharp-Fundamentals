namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                List<string> commands = Console.ReadLine().Split().ToList();

                if (commands[0] == "end")
                {
                    break;
                }
                else if (commands[0] == "Delete")
                {
                    while (numbers.Contains(int.Parse(commands[1])))
                    {
                        numbers.Remove(int.Parse(commands[1]));
                    }
                }
                else if (commands[0] == "Insert")
                {
                    int insertIndex = int.Parse(commands[1]);
                    int number = int.Parse(commands[2]);
                    numbers.Insert(number, insertIndex);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
