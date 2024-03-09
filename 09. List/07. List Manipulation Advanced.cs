namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int changes = 0;
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
                    changes++;
                }
                else if (input[0] == "Remove")
                {
                    numbers.Remove(int.Parse(input[1]));
                    changes++;
                }
                else if (input[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(input[1]));
                    changes++;
                }
                else if (input[0] == "Insert")
                {
                    int numberToInsert = int.Parse(input[1]);
                    int indexToInsert = int.Parse(input[2]);
                    numbers.Insert(indexToInsert, numberToInsert);
                    changes++;
                }
                else if (input[0] == "Contains")
                {
                    if (numbers.Contains(int.Parse(input[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (input[0] == "PrintEven")
                {
                    string even = "";
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            even += " " + numbers[i];
                        }
                    }
                    Console.WriteLine(even);
                }
                else if (input[0] == "PrintOdd")
                {
                    string odd = "";
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 1)
                        {
                            odd += " " + numbers[i];
                        }
                    }
                    Console.WriteLine(odd);
                }
                else if (input[0] == "GetSum")
                {
                    int sum = 0;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }
                    Console.WriteLine(sum);
                }
                else if (input[0] == "Filter")
                {
                    int number = int.Parse(input[2]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (input[1] == "<")
                        {
                            if (numbers[i] < number)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        else if (input[1] == ">")
                        {
                            if (numbers[i] > number)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        else if (input[1] == ">=")
                        {
                            if (numbers[i] >= number)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        else if (input[1] == "<=")
                        {
                            if (numbers[i] <= number)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }


                    }
                    Console.WriteLine();
                }
            }
            if(changes > 0)
            {
                Console.WriteLine(string.Join (" ", numbers));
            }
        }
    }
}
