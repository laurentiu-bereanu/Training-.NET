using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHomeworks.Tema_OOP
{
    public class Employee : Person
    {
        public int EmployeeId { get; set; }
        public string Department { get; set; }

        private decimal _salary;

        public decimal GetSalary()
        {
            return _salary;
        }

        public void SetSalary(decimal salary)
        {
            if (salary < 0)
            {
                throw new ArgumentException("Salary cannot be negative.");
            }
            _salary = salary;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($@"
                \n Name: {Name},
                \n Employee ID: {EmployeeId},
                \n Department: {Department}");
        }
    }
}
