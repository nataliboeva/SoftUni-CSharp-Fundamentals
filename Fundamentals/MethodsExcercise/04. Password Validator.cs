namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Validator(input);
        }
        static void Validator(string password)
        {
            bool isValid = true;
            if (password.Length > 10 || password.Length < 6)
            {
                Console.WriteLine("Password must be between 6 and 10 characters ");
                isValid = false;
            }
            if(!password.All(char.IsLetterOrDigit)) 
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }
            if (password.Count(char.IsDigit) < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }
            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
