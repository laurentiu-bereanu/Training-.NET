namespace TrainingHomeworks.Tema3
{
    public class Homework
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test3()
        {

            Person.FirstName = "John";
            Person.LastName = "Doe";
            Person.Age = 30;
            Person.Gender = "Male";

            Person.IsOld();
            Person.ShowGender();
        }
    }
}