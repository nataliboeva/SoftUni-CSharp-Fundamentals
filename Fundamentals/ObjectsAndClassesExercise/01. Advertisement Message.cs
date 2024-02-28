namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Random random = new Random();
            string[] phrases = {"Excellent product.", "Such a great product.",
                "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can't live without this product." };
            string[] events = {"Now I feel good.", "I have succeeded with this " +
                "product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, " +
                "I am very satisfied.", "I feel great!"};
            string[] authors = {"Diana", "Petya", "Stella", "Elena", "Katya",
                "Iva", "Annie", "Eva"};
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            for (int i = 0; i < num; i++)
            {
                string phrase = phrases[random.Next(0, phrases.Length)];
                string eventa = events[random.Next(0, events.Length)];
                string author = authors[random.Next(0, authors.Length)];
                string city = cities[random.Next(0, cities.Length)];

                Console.WriteLine("{0} {1} {2} - {3}", phrase, eventa, author, city);
            }
        }
    }
}
