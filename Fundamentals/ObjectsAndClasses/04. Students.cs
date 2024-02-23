
namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Student> students = new List<Student>();
            while ((input = Console.ReadLine()) != "end")
            {
                string[] information = input.Split();

                string firstNameInfo = information[0];
                string lastNameInfo = information[1];
                int ageInfo = int.Parse(information[2]);
                string homeTown = information[3];

                Student student = new Student()
                {
                    FirstName = firstNameInfo,
                    LastName = lastNameInfo,
                    Age = ageInfo,
                    HomeTown = homeTown,

                };
                students.Add(student);

            }
            string city = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.HomeTown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}