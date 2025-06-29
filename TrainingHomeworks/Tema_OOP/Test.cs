namespace TrainingHomeworks.Tema_OOP
{
    public class Homework
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            List<Person> people = new List<Person>
            {
                new Employee { Name = "Alice", EmployeeId = 1011, Department = "HR" },
                new Employee { Name = "Bob", EmployeeId = 1022, Department = "IT" },
            };

            foreach (var persons in people)
            {
                persons.DisplayInfo();
            }

            Person person = new Employee
            {
                Name = "John Doe",
                EmployeeId = 123,
                Department = "Finance"
            };

            person.DisplayInfo();

        }

        [Test]
        public void Test2()
        {
            List<Person> people = new List<Person>
            {
                new Employee { Name = "Alice", EmployeeId = 1011, Department = "HR" },
                new Employee { Name = "Bob", EmployeeId = 1022, Department = "IT" },
                new Manager { Name = "Charlie"}
            };

           
            foreach (var persons in people)
            {
                if (persons is Manager manager)
                {
                    manager.SetTeamSize(5);
                    manager.SetBonus(1000);
                }
                else if (persons is Employee employee)
                {
                    employee.SetSalary(50000);
                }

                persons.DisplayInfo();
            }

        }
    }
}