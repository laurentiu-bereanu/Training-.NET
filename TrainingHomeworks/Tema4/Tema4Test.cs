namespace TrainingHomeworks.Tema4
{
    public class Homework
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test4()
        {

            Person.FirstName = "John";
            Person.LastName = "Doe";
            Person.Age = 30;
            Person.Gender = "Male";

            Person.AddSkill("Cooking");
            Person.AddSkill("Photography");
            Person.AddSkill("Ninja");
            Person.AddSkill("Swimming");
            Person.AddSkill("CIA");
            Person.AddSkill("Dancing");

            Person.DisplaySkills();
        }
    }
}