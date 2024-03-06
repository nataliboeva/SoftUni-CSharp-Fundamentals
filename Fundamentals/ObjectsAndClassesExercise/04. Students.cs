namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> info = new List<Students>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Students newStudent = new Students(input[0], input[1], double.Parse(input[2]));
                info.Add(newStudent);
            }
            List<Students> orderedByGrade = info.OrderByDescending(student => student.Grade).ToList();

            foreach (Students student in orderedByGrade)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Students(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}
