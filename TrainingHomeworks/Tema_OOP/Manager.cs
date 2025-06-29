using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHomeworks.Tema_OOP
{
    public class Manager : Person
    {
        private int _teamSize;

        private decimal _bonus;

        public void SetTeamSize(int teamSize)
        {
            if (teamSize < 0)
            {
                throw new ArgumentException("Team size cannot be negative.");
            }
            _teamSize = teamSize;
        }

        public int GetTeamSize()
        {
            return _teamSize;
        }

        public void SetBonus(decimal bonus)
        {
            if (bonus < 0)
            {
                throw new ArgumentException("Bonus cannot be negative.");
            }
            _bonus = bonus;
        }

        public decimal GetBonus()
        {
            return _bonus;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($@"
                \n Manager Name: {Name},
                \n Leads a team of {_teamSize} people,
                \n Bonus: {_bonus}");

        }
    }
}
