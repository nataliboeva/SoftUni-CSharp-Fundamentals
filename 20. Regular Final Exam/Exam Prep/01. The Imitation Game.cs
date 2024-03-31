namespace Exam_Prep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "Decode")
            {
                string[] token = input.Split('|');
                string command = token[0];
                if (command == "Move")
                {
                    int numberOfLetters = int.Parse(token[1]);
                    string keep = encryptedMessage.Substring(0, numberOfLetters);
                    encryptedMessage = encryptedMessage.Remove(0, numberOfLetters);
                    encryptedMessage += keep;
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(token[1]);
                    string value = token[2];
                    encryptedMessage = encryptedMessage.Insert(index, value);
                }
                else if (command == "ChangeAll")
                {
                    string substring = token[1];
                    string replacement = token[2];
                    encryptedMessage = encryptedMessage.Replace(substring, replacement);
                }
            }
            Console.WriteLine("The decrypted message is: " + encryptedMessage);
        }
    }
}
