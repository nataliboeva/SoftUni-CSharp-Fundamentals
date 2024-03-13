namespace _03._Orders
{   
    class Program
    {
        class Product
        {
            public Product(string name, decimal price, decimal quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }

            public decimal TotalPrice => Price * Quantity;
            public void Update(decimal newPrice, decimal newQuantity)
            {
                Price = newPrice;
                Quantity += newQuantity;
            }
            public override string ToString()
            {
                return $"{Name} -> {TotalPrice:F2}";
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();
            string input;
            while((input = Console.ReadLine()) != "buy")
            {
                string[] command = input.Split();

                string product = command[0];
                decimal price = decimal.Parse(command[1]);
                decimal quantity = decimal.Parse(command[2]);

                Product newProduct = new Product(product, price, quantity);

                if (!products.ContainsKey(newProduct.Name))
                {
                    products.Add(newProduct.Name, newProduct);
                }
                else
                {
                    products[newProduct.Name].Update(newProduct.Price, newProduct.Quantity);
                }         
            }

            foreach(KeyValuePair<string, Product> productPair in products)
            {
                Console.WriteLine(productPair.Value);
            }
        }
    } 
}
