using System.Text;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            StringBuilder sb = new StringBuilder(capacity: line.Length);
            int strength = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '>')
                {
                    strength += line[i + 1] - '0';
                    sb.Append(line[i]);
                }
                else if(strength > 0)
                {
                    strength--;
                }
                else
                {
                    sb.Append(line[i]);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
