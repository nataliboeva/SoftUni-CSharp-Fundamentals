namespace _03._School_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split('&', StringSplitOptions.RemoveEmptyEntries).ToList();

            string input;
            while ((input = Console.ReadLine()) != "Done")
            {
                string[] book = input
                    .Split(" | ", StringSplitOptions.RemoveEmptyEntries);

                if (book[0] == "Add Book")
                {
                    if (! list.Contains(book[1]))
                    {
                        list.Insert(0, book[1]);
                    }  
                }
                else if (book[0] == "Take Book")
                {
                    if (list.Contains(book[1]))
                    {
                        list.Remove(book[1]);
                    }
                }
                else if (book[0] == "Swap Books")
                {
                    if (list.Contains(book[1]) && list.Contains(book[2]))
                    {
                        SwapBooks(list, book[1], book[2]);
                    }
                }
                else if (book[0] == "Insert Book")
                {
                    if (!list.Contains(book[1]))
                    {
                        list.Add(book[1]);
                    }
                }
                else if (book[0] == "Check Book")
                {
                    int index = int.Parse(book[1]);
                    if(index >= 0 && index < list.Count)
                    {
                        Console.WriteLine(list[index]);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", list));
        }
        static void SwapBooks(List<string> list, string bookOne, string bookTwo)
        {
            int first = list.IndexOf(bookOne);
            int second = list.IndexOf(bookTwo);

            string swap = list[first];
            list[first] = list[second];
            list[second] = swap;
        }
    }
}
