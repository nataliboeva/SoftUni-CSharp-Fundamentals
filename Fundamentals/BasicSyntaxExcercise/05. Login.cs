namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            char[] neshto = username.ToCharArray();
            Array.Reverse(neshto);
            string password = new string(neshto);

            int attempt = 4;
            while (attempt > 0)
            {
                attempt--;
                string typed = Console.ReadLine();
                if (typed == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    if(attempt == 0)
                    {
                        Console.WriteLine($"User {username} blocked!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                    
                }
            }
        }
    }
}
