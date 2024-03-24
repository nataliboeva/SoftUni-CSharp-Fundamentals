using System.Text;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            decimal result = 0;
            for (int i = 0; i < line.Length; i++)
            {
                string current = line[i];
                char before = current[0];
                char after = current[current.Length - 1];
                decimal number = int.Parse(current.Substring(1, current.Length - 2));
                decimal score = 0;
                if (char.IsUpper(before)) score += number / (before - 'A' + 1);
                else score += number * (before - 'a' + 1);

                if (char.IsUpper(after)) score -= after - 'A' + 1;
                else score += after - 'a' + 1;

                result += score;
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}
