namespace TrainingHomeworks.Tema5
{
    public class Homework
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test5()
        {
            Person.FirstName = "John";
            Person.LastName = "Doe";
            Person.Age = 30;
            Person.Gender = "Male";

            Person.CountTo(100);
        }
    }
}