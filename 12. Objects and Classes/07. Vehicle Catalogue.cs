using System.Numerics;

namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            while ((input = Console.ReadLine()) != "end")
            {
                string[] data = input.Split('/');
                string type = data[0];
                string brand = data[1];
                string model = data[2];
                double power = double.Parse(data[3]);

                if(type == "Car")
                {
                    Car car = new Car();
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = power;
                    cars.Add(car);
                }
                else if(type == "Truck")
                {
                    Truck truck = new Truck();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = power;
                    trucks.Add(truck);
                }
            }
            if(cars.Count > 0)
            {
                Console.WriteLine("Cars: ");
                foreach (Car car in cars.OrderBy(car => car.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if(trucks.Count > 0)
            {
                Console.WriteLine("Trucks: ");
                foreach (Truck truck in trucks.OrderBy(truck => truck.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }     
        }
        class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public double Weight { get; set; }
        }
        class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public double HorsePower { get; set; }
        }
    }
}
