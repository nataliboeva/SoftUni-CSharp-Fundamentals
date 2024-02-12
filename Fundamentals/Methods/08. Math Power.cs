namespace _08._Math_Power
{
    internal class Program
    {
        static double Pow(double num, double power)
        {
            return Math.Pow(num,power);
        }
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double pow = Pow(number, power);
            Console.WriteLine(pow);
        }
    }
}
