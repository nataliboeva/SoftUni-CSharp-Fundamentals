namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(VowelsCount(text));
        }
        static int VowelsCount(string value)
        {
            int count = 0;
            foreach (var character in value)
            {
                if (IsVowel(character))
                {
                    count++;
                }
            }
            return count;
        }
        static bool IsVowel(char character)
        {
            return "aeouiAEOUI".IndexOf(character) >= 0;
        }
    }
}
