
namespace _05._Students_2._0
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
                if(IsExisting(students, firstNameInfo, lastNameInfo))
                {
                    Student student = GetStudent(students, firstNameInfo, lastNameInfo);
                    student.FirstName = firstNameInfo;
                    student.LastName = lastNameInfo;
                    student.Age = ageInfo;
                    student.HomeTown = homeTown;
                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = firstNameInfo,
                        LastName = lastNameInfo,
                        Age = ageInfo,
                        HomeTown = homeTown,
                    };
                    students.Add(student);
                }
            }
            string city = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.HomeTown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} " +
                        $"is {student.Age} years old.");
                }
            }
        }

        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;

        }

        static bool IsExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if(student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
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
