using System.Text;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if(i == 0 || text[i - 1] != text[i])
                {
                    sb.Append(text[i]);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
