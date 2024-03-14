namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> registration = new Dictionary<string, string>();
            for (int i = 0; i < n; i++) 
            {
                string[] command = Console.ReadLine().Split().ToArray();
                string name = command[1];
                if (command[0] == "register")
                {
                    string plate = command[2];
                    if (registration.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plate}");
                    }
                    else
                    {
                        Console.WriteLine($"{name} registered {plate} successfully");
                        registration.Add(name, plate);
                    }
                }
                else if (command[0] == "unregister")
                {
                    if (!registration.ContainsKey(name)) 
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{name} unregistered successfully");
                        registration.Remove(name);
                    }
                }
            }
                foreach(var reg in registration)
                {
                    Console.WriteLine(reg.Key + " => " + reg.Value);
                }
        }
    }
}
