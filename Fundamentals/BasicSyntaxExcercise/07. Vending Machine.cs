using System.Data.SqlTypes;
using System.Threading.Channels;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal balance = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Start")
                {
                    break;
                }
                decimal coin = decimal.Parse(input);
                if (coin == 0.1m || coin == 0.2m || coin == 0.5m ||
                    coin == 1m || coin == 2m)
                {
                    balance += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
            }
            while (true)
            {
                string input = Console.ReadLine();
                if( input == "End")
                {
                    break;
                }
                switch (input)
                {
                    case "Nuts":
                        if(balance >= 2.0m)
                        {
                            Console.WriteLine("Purchased nuts");
                            balance -= 2.0m;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (balance >= 0.7m)
                        {
                            Console.WriteLine("Purchased water");
                            balance -= 0.7m;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (balance >= 1.5m)
                        {
                            Console.WriteLine("Purchased crisps");
                            balance -= 1.5m;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (balance >= 0.8m)
                        {
                            Console.WriteLine("Purchased soda");
                            balance -= 0.8m;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (balance >= 1.0m)
                        {
                            Console.WriteLine("Purchased coke");
                            balance -= 1.0m;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;

                }
            }
            Console.WriteLine($"Change: {balance:f2}");
        }
    }
}
