namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static double AreaOfRectangle(double width, double height)
        {
            return width * height;
        }
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = AreaOfRectangle(width, height);
            Console.WriteLine(area);
        }
    }
}
