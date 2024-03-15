namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if(!students.ContainsKey(student))
                {
                    students.Add(student, new List<double>());
                }
                students[student].Add(grade);            
            }
            foreach(var info in students)
            {
                if(info.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{info.Key} -> {info.Value.Average():f2}");
                }
                
            }
        }
    }
}
