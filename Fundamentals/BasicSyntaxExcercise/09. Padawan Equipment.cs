namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double Lightsaber = double.Parse(Console.ReadLine());
            double Robe = double.Parse(Console.ReadLine());
            double Belt = double.Parse(Console.ReadLine());

            double sabersPrice = Lightsaber * (students + (Math.Ceiling(students * 0.1)));
            double robesPrice = Robe * students;

            double beltPrice = Belt * ( students - Math.Ceiling((double)(students / 6)));

            double totalPrice = sabersPrice + robesPrice + beltPrice;
            if (totalPrice > money)
            {
                Console.WriteLine($"John will need {totalPrice - money:f2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
        }
    }
}
