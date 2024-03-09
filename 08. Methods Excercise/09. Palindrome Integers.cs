namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Palindrome(text);
        }
        static void Palindrome(string input)
        {

            while (input!= "END")
            {
                char[] cArray = input.ToCharArray();
                string reverseInput = "";
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reverseInput += cArray[i];
                }
                if(input.Length == 1)
                {
                    Console.WriteLine(true);
                }
                else if (input == reverseInput)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
                input = Console.ReadLine();

            }
        }
    }
}
