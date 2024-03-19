namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ").ToArray();
            for (int i = 0; i < usernames.Length; i++)
            {
                if (IsValid(usernames[i]))
                {
                    Console.WriteLine(usernames[i]);
                }
            }
        }
        static bool IsValid(string username)
        {
            if (username.Length >= 3 && username.Length <= 16)
            {
                for (int i = 0; i < username.Length; i++)
                {
                    if (!char.IsLetter(username[i]) && !char.IsDigit(username[i]) && username[i] != '-' && username[i] != '_')
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
