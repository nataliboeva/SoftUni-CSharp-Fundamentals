namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, List<string>> employees = new Dictionary<string, List<string>>(); 
            while((input = Console.ReadLine()) != "End")
            {
                string[] arr = input.Split(" -> ").ToArray();
                string company = arr[0];
                string id = arr[1];

                if(!employees.ContainsKey(company))
                {
                    employees.Add(company, new List<string>());
                }
                if (!employees[company].Contains(id))
                {
                    employees[company].Add(id);
                }
            }
            foreach(var  employee in employees)
            {
                Console.WriteLine(employee.Key);
                foreach(var id in  employee.Value)
                {
                    Console.WriteLine("-- " + id);
                }
            }
        }
    }
}
