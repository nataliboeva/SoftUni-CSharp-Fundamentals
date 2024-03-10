namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Vehicle> vehicles = new List<Vehicle>();
            List<double> truckPower = new List<double>();
            List<double> carPower = new List<double>();
            while((input = Console.ReadLine()) != "End")
            {
                string[] catalogue = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                Vehicle vehicle = new Vehicle(catalogue[0], catalogue[1], catalogue[2], double.Parse(catalogue[3]));
                if (catalogue[0] == "truck" || catalogue[0] == "Truck")
                {
                    truckPower.Add(double.Parse(catalogue[3]));
                    vehicle.TypeOfVehicle = "Truck";
                }
                else if (catalogue[0] == "car" || catalogue[0] == "Car")
                {
                    carPower.Add(double.Parse(catalogue[3]));
                    vehicle.TypeOfVehicle = "Car";
                }
                vehicles.Add(vehicle);
            }
            string value;
            while((value = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (Vehicle vehicle in vehicles)
                {
                    if(value == vehicle.Model)
                    {
                        Console.WriteLine($"Type: {vehicle.TypeOfVehicle}");
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                    }
                }
            }
          
            if (carPower.Count > 0)
            {
                double carAverage = carPower.Average();
                Console.WriteLine($"Cars have average horsepower of: {carAverage:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            if (truckPower.Count > 0)
            {
                double truckAverage = truckPower.Average();
                Console.WriteLine($"Trucks have average horsepower of: {truckAverage:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
    }
    class Vehicle
    {
        public string TypeOfVehicle {  get; set; }

        public string Model {  get; set; }

        public string Color { get; set; }

        public double HorsePower { get; set; }

        public Vehicle(string type, string model, string color, double horsePower)
        {
            TypeOfVehicle = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
    }
}
