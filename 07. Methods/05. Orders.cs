namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfPurchase = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            Purchse(typeOfPurchase, num);
        }
            static void Purchse(string purchase, int quantity)
        {
            double sum = 0;
            switch (purchase)
            {
                case "coffee":
                    sum += 1.50;
                    break;
                case "water":
                    sum += 1.0;
                    break;
                case "coke":
                    sum += 1.40;
                    break;
                case "snacks":
                    sum += 2.0;
                    break;
                default:
                    break;

            }
                Console.WriteLine($"{sum * quantity:f2}");

        }
    }
}
