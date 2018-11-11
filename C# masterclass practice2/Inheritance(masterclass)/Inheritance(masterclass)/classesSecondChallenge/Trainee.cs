using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_masterclass_.classesSecondChallenge
{

    class Trainee: Employee
    {
        //properties
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        //constructors
        public Trainee()
        {
            WorkingHours = 0;
            SchoolHours = 0;
        }

        public Trainee(string name, string firstName,int salary, int workinghours, int schoolhours)
            :base(name, firstName, salary)
        {
            this.WorkingHours = workinghours;
            this.SchoolHours = schoolhours;
        }

        //methods
        public void Learn()
        {
            Console.WriteLine("{0} is learning for {1} hours", FirstName, SchoolHours);
        }

        public void Work()
        {
            Console.WriteLine("{0} is working for {1} hours", FirstName, SchoolHours);
        }
    }
}
