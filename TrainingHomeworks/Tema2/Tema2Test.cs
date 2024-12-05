namespace TrainingHomeworks.Tema2
{
    public class Homework
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test2()
        {

            Person.FirstName = "John";
            Person.LastName = "Doe";
            Person.Age = 30;
            Person.Gender = "Male";

            Person.DisplayDetails();

            int afterYears = 15;
            int ageInFuture = Person.ComputeAgeAfterYears(afterYears);
            Console.WriteLine($"\nYou will be {ageInFuture} years old in {afterYears} years!");
        }
    }
}