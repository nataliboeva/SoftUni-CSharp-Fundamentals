namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {

                List<string> input = Console.ReadLine().Split().ToList();
                if (input[0] == "end")
                {
                    break;
                }
                else if (input[0] == "Add")
                {
                    numbers.Add(int.Parse(input[1]));
                }
                else if (input[0] == "Remove")
                {
                    numbers.Remove(int.Parse(input[1]));
                }
                else if (input[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(input[1]));
                }
                else if (input[0] == "Insert")
                {
                    int numberToInsert = int.Parse(input[1]);
                    int indexToInsert = int.Parse(input[2]);
                    numbers.Insert(indexToInsert, numberToInsert);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
