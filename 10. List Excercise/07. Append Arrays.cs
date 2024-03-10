namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrays = Console.ReadLine()
                .Split('|' , StringSplitOptions.RemoveEmptyEntries);

            List<string> symbols = ExtractSymbols(arrays);
            Console.WriteLine(string.Join(" ", symbols));
        }
        static List<string> ExtractSymbols(string[] arrays)
        {
            List<string> result = new List<string>();

            for(int i = arrays.Length - 1; i >= 0; i--)
            {
                string[] array = arrays[i]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                result.AddRange(array);
            }
            return result;
        }
    }
}
