namespace Problem_2___Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input;
            int shooted = 0;
            while ((input = Console.ReadLine()) != "End")
            {
                int index = int.Parse(input);

                if (index >= 0 && index <= numbers.Count - 1)
                {
                    if (numbers[index] == -1)
                    {
                        continue;
                    }
                    int shot = numbers[index];
                    numbers[index] = -1;
                    shooted++;

                    for (int i = 0; i <= numbers.Count - 1; i++)
                    {
                        if (numbers[i] != -1)
                        {
                            if (shot >= numbers[i])
                            {
                                numbers[i] += shot;
                            }
                            else
                            {
                                numbers[i] -= shot;
                            }
                        }           
                    }
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine($"Shot targets: {shooted} -> " + string.Join(" ", numbers));
        }
    }
}
