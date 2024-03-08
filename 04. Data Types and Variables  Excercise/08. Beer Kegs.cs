using System.Threading.Channels;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            string biggestModel = "";
            double biggestKeg = 0;
            for (int i = 1; i <= lines; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = (Math.PI * Math.Pow(radius,2) * height);

                if(volume > biggestKeg)
                {
                    biggestKeg = volume;
                    biggestModel = model;
                }
            }
            Console.WriteLine(biggestModel);
        }
    }
}
