namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int capacity = int.Parse(Console.ReadLine());

            List<string> command = Console.ReadLine().Split().ToList();
            while(true)
            {
                if (command[0] == "end")
                {
                    break;
                }
                else if (command[0] == "Add")
                {
                    wagons.Add(int.Parse(command[1]));
                }
                else
                {
                    for (int i = 0; i <= wagons.Count - 1; i++)
                    {
                        if (int.Parse(command[0]) + wagons[i] <= capacity)
                        {
                            wagons[i] += int.Parse(command[0]);
                            break;
                        }
                    }
                }
                command = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
