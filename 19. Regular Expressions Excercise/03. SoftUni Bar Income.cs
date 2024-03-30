using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        class Bar
        {
            public string Name {  get; set; }
            public string Product { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Total => Price * Quantity;

        }
        static void Main(string[] args)
        {
            List<Bar> list = new List<Bar>();
            string input;
            string pattern = @"\%(?<name>[A-z][a-z]+)\%[^|$%.]*\<(?<product>\w+)\>[^|$%.]*\|(?<quantity>\d+)\|(?<price>\d+\.\d+|\d+)\$";
            decimal totalIncome = 0;
            while((input = Console.ReadLine()) != "end of shift")
            {
                foreach(Match match in Regex.Matches(input,pattern))
                {
                    Bar bar = new Bar();
                    bar.Name = match.Groups["name"].Value;
                    bar.Product = match.Groups["product"].Value;
                    bar.Quantity = int.Parse(match.Groups["quantity"].Value);
                    bar.Price = decimal.Parse(match.Groups["price"].Value);
                    list.Add(bar);
                    totalIncome += bar.Total;
                    Console.WriteLine($"{bar.Name}: {bar.Product} - {(bar.Price * bar.Quantity):f2}");
                }
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
