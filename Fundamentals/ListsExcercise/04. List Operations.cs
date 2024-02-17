namespace _04._List_Operations
{
    internal class Program
    {
        static bool OutsideOfTheArray (int index, int lenght)
        {
            return index < 0 || index > lenght;

        }
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();
                if (command[0] == "Add")
                {
                    numbers.Add(int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    int last = numbers.Count - 1;

                    if(OutsideOfTheArray(index, last))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    else
                    {
                        numbers.Insert(index, number);
                    }      

                }
                else if (command[0] == "Remove")
                {
                    int index = int.Parse(command[1]);
                    int last = numbers.Count - 1;
                    if (OutsideOfTheArray(index, last) == true)
                    {       
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (command[0] == "Shift")
                {
                    string direction = command[1];
                    int count = int.Parse(command[2]);
                    count %= numbers.Count;
                    if (direction == "left")
                    {
                        List<int> shiftedPart = numbers.GetRange(0, count);
                        numbers.RemoveRange(0, count);
                        numbers.InsertRange(numbers.Count, shiftedPart);
                    }
                    else if (direction == "right")
                    {
                        List<int> shiftedPart = numbers.GetRange(numbers.Count - count, count);
                        numbers.RemoveRange(numbers.Count - count, count);
                        numbers.InsertRange(0, shiftedPart);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
