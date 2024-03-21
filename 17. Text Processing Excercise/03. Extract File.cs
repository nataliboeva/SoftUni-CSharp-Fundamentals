namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int lastIndex = input.LastIndexOf("\\");
            string fullFileName = input.Substring(lastIndex + 1);

            int lastDot = fullFileName.LastIndexOf('.');
            string name = fullFileName.Substring(0, lastDot);
            string extension = fullFileName.Substring(lastDot + 1);

            Console.WriteLine("File name: " + name);
            Console.WriteLine("File extension: " + extension);
        }
    }
}
