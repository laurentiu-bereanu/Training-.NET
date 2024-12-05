using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHomeworks.Tema2
{
    public static class Person
    {

        public static String FirstName { get; set; } = string.Empty;

        public static  String LastName { get; set; } = string.Empty;

        public static String Gender { get; set; } = string.Empty;

        public static int Age { get; set; }

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
    }
}

