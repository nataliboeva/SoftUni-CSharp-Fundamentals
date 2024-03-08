namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            double sum = 0;

            if (group == "Students")
            {
                switch (day)
                {
                    case "Friday":
                        price += 8.45;
                        break;
                    case "Saturday":
                        price += 9.80;
                        break;
                    case "Sunday":
                        price += 10.46;
                        break;
                }
                sum += price * people;
                if (people >= 30)
                {
                    sum -= (price * people) * 0.15;
                }

            }
            else if (group == "Business")
            {
                switch (day)
                {
                    case "Friday":
                        price += 10.90;
                        break;
                    case "Saturday":
                        price += 15.60;
                        break;
                    case "Sunday":
                        price += 16;
                        break;
                }
                sum += price * people;
                if (people >= 100)
                {
                    sum = price * (people - 10);
                }
            }
            else if (group == "Regular")
            {
                switch (day)
                {
                    case "Friday":
                        price += 15;
                        break;
                    case "Saturday":
                        price += 20;
                        break;
                    case "Sunday":
                        price += 22.50;
                        break;
                }
                sum += price * people;
                if (people >=10 & people <= 20)
                {
                    sum *= 0.05;
                }
            }
            Console.WriteLine($"Total price: {sum:f2}");

        }
        }
    }
