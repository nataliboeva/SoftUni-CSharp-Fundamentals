namespace _05._Courses
{
    internal class Program
    {
        class Courses
        {
            public string Name { get; set; }
            public List<string> StudentNames { get; set; }
            public Courses(string name)
            {
                Name = name;
                StudentNames = new List<string>();
            }
            public override string ToString()
            {
                string result = $"{Name}: {StudentNames.Count}\n";
                for (int i = 0; i < StudentNames.Count; i++)
                {
                    result += $"-- {StudentNames[i]}\n";
                }
                return result.Trim();
            }
        }
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, Courses> registredStu = new Dictionary<string, Courses>();
            while((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(" : ").ToArray();
                string course = command[0];
                string student = command[1];
                if (!registredStu.ContainsKey(course))
                {
                    Courses courses = new Courses(course);
                    registredStu.Add(course, courses);
                }
                registredStu[course].StudentNames.Add(student);
            }
            foreach (Courses course in registredStu.Values)
            {
                Console.WriteLine(course);
            }
        }
    }
}
