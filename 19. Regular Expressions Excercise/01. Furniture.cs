using System.Text.RegularExpressions;

namespace Regular_Expressions_Excercise
{
    internal class Program
    {
        class Furniture
        {
            public string Name { get; set; }

            public decimal Price { get; set; }

            public int Quantity { get; set; }

            public decimal Total => Price * Quantity;
            static void Main(string[] args)
            {
                List<Furniture> furnitures = new List<Furniture>();
                string pattern = @">>(?<furnitures>[A-Za-z]+)<<(?<price>\d+\.\d+|\d+)!(?<quantity>\d+)";
                string input;
                while ((input = Console.ReadLine()) != "Purchase")
                {
                    foreach (Match match in Regex.Matches(input, pattern))
                    {
                        Furniture furniture = new Furniture();
                        furniture.Name = match.Groups["furnitures"].Value;
                        furniture.Price = decimal.Parse(match.Groups["price"].Value);
                        furniture.Quantity = int.Parse(match.Groups["quantity"].Value);

                        furnitures.Add(furniture);
                    }
                }
                Console.WriteLine("Bought furniture:");
                decimal totalSpend = 0;
                foreach(Furniture furniture in furnitures)
                {
                    Console.WriteLine(furniture.Name);
                    totalSpend += furniture.Total;
                }
                Console.WriteLine($"Total money spend: {totalSpend:f2}");
            }
        }
    }
}
