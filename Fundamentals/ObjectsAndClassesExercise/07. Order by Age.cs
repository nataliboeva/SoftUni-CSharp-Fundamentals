namespace _07._Order_by_Age
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string Id { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            string input;
            List<Person> people = new List<Person>();
            while((input = Console.ReadLine()) != "End")
            {
                string[] lines = input.Split();
                string name = lines[0];
                string id = lines[1];
                int age = int.Parse(lines[2]);

                Person person = new Person();
                person.Name = name;
                person.Id = id;
                person.Age = age;
                
                var foundId = people.FirstOrDefault(p => p.Id == person.Id);

                if(foundId != null)
                {
                    foundId.Age = person.Age;
                    foundId.Name = person.Name;
                }
                else
                {
                    people.Add(person);
                }
            }
            List <Person> orrderPpl = people.OrderBy(people => people.Age).ToList();
            foreach(Person person in orrderPpl)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
}
