namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Random random = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = random.Next(words.Length);
                string word = words[i];
                string randomIndexWord = words[randomIndex];

                words[i] = randomIndexWord;
                words[randomIndex] = word;

            }
            Console.WriteLine(string.Join(Environment.NewLine, words));
        }

    }
}
