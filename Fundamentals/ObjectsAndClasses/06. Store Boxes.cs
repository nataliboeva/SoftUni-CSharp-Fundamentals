namespace _06._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Box> boxes = new List<Box>();
            while ((input = Console.ReadLine()) != "end")
            {
                string[] data = input.Split();
                string serialNum = data[0];
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                double itemPrice = double.Parse(data[3]);

                Box box = new Box()
                {
                    SerialNumber = serialNum,
                    Item = itemName,
                    ItemQuantity = itemQuantity,
                    PricePerBox = itemPrice,
                    TotalPrice = itemPrice * itemQuantity,

                };
                boxes.Add(box);

            }
            List<Box> sortedBox = boxes.OrderByDescending(boxes => boxes.TotalPrice).ToList();
            foreach (Box box in sortedBox)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine("-- " + box.Item + "- " + "$" + box.PricePerBox + ": " + box.ItemQuantity);
                Console.WriteLine($"--  {box.TotalPrice:f2}");
            }
        }
        class Box
        {
            public string SerialNumber { get; set; }
            public string Item { get; set; }
            public int ItemQuantity { get; set; }
            public double PricePerBox { get; set; }
            public double TotalPrice { get; set; }

        }
    }

}
