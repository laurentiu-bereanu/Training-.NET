namespace TrainingHomeworks.Tema4
{
    public static class Person
    {

        public static String FirstName { get; set; } = string.Empty;

        public static String LastName { get; set; } = string.Empty;

        public static String Gender { get; set; } = string.Empty;

        public static int Age { get; set; }

        public static List<String> Skills { get; set; } = [];

        public static int ComputeAgeAfterYears(int years)
        {
            return Age + years;
        }

        public static void DisplayDetails()
        {
            Console.WriteLine("The person's details are as follows:");
            Console.WriteLine($"\t- First Name: {FirstName}");
            Console.WriteLine($"\t- Last Name: {LastName}");
            Console.WriteLine($"\t- Gender: {Gender}");
        }

        public static void IsOld()
        {
            if (Age >= 100)
            {
                Console.WriteLine("You are ancient!");
            }
            else if (Age >= 50)
            {
                Console.WriteLine("You are old!");
            }
            else { Console.WriteLine("You are still young!"); }
        }

        public static void ShowGender()
        {
            if (Gender.Equals("Male"))
            {
                Console.WriteLine("You are a male!");
            }
            else if (Gender.Equals("Female"))
            {
                Console.WriteLine("You are a female!");
            }
            else { Console.WriteLine("You haven't specified your gender!"); }
        }

        public static void AddSkill(String skill)
        {
            Skills.Add(skill);
            Console.WriteLine($"Added a new skill: {skill}");
        }

        public static void DisplaySkills()
        {
            Console.WriteLine("The person has the following skills:");

            foreach (String skill in Skills)
            {
                if (skill.Equals("Ninja")) continue;

                if (skill.Equals("CIA"))
                {
                    Console.WriteLine("\n >>>>>> Classified information, no further skills are displayed! <<<<<<");
                    break;
                }

                Console.Write($"{skill}; ");

            }
        }
    }
}

