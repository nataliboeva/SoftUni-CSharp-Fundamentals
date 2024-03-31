namespace _03._Need_for_Speed_III
{
    internal class Program
    {
        class Car
        {
            public string Name { get; set; }
            public uint Mileage { get; set; }
            public uint Fuel { get; set; }

            public Car(string name, uint mileage, uint fuel)
            {
                Name = name;
                Mileage = mileage;
                Fuel = fuel;
            }
            
        }
        static void Main(string[] args)
        {
            int numOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < numOfCars; i++)
            {
                string[] info = Console.ReadLine().Split('|');
                string name = info[0];
                uint mileage = uint.Parse(info[1]);
                uint fuel = uint.Parse(info[2]);

                cars.Add(new Car(name, mileage, fuel));
            }
            string input;
            while((input = Console.ReadLine()) != "Stop")
            {
                string[] token = input.Split(" : ");
                string command = token[0];
                string model= token[1];
                Car car = cars.First(x => x.Name == model);
                if (command == "Drive")
                {
                    uint distance = uint.Parse(token[2]);
                    uint fuel = uint.Parse(token[3]);
                    if (car.Fuel < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                        continue;
                    }
                    car.Mileage += distance;
                    car.Fuel -= fuel;
                    Console.WriteLine($"{model} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    if (car.Mileage >= 100_000)
                    {
                        Console.WriteLine($"Time to sell the {model}!");
                        cars.Remove(car);
                    }
                }
                else if (command == "Refuel")
                {
                    uint fuel = uint.Parse(token[2]);
                    if (car.Fuel + fuel >= 75)
                    {
                        Console.WriteLine($"{model} refueled with {75 - car.Fuel} liters");
                        car.Fuel = 75;
                    }
                    else
                    {
                        car.Fuel += fuel;
                        Console.WriteLine($"{model} refueled with {fuel} liters");
                    }
                }
                else if (command == "Revert")
                {
                    uint kilometers = uint.Parse(token[2]);
                    if (car.Name == model)
                    {
                        car.Mileage -= kilometers;
                        if (car.Mileage < 10_000)
                        {
                            car.Mileage = 10_000;
                            continue;
                        }
                        Console.WriteLine($"{model} mileage decreased by {kilometers} kilometers");
                    }
                }
                
            }
            foreach(Car car in cars)
            {
                Console.WriteLine($"{car.Name} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }
        }
    }
}
