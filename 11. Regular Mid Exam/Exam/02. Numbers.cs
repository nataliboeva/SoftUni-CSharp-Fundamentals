namespace _02._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input;
            while ((input = Console.ReadLine()) != "Finish")
            {              
                string[] command = input.Split();
                int value = int.Parse(command[1]);

                if (command[0] == "Add")
                {
                    numbers.Add(value);
                }
                else if(command[0] == "Remove")
                {
                    if (numbers.Contains(value))
                    {
                        numbers.Remove(value);
                    }
                }
                else if(command[0] == "Replace")
                {               
                    if (numbers.Contains(value))
                    {
                        int index = numbers.IndexOf(value);
                        int replacement = int.Parse(command[2]);
                        numbers.Remove(value);
                        numbers.Insert(index, replacement);
                        //
                    }
                }
                else if (command[0] == "Collapse")
                {
                    for (int i = 0; i <= numbers.Count - 1; i++)
                    {
                        if (numbers[i] < value)
                        {
                            numbers.RemoveAt(i);
                            i--;

                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
