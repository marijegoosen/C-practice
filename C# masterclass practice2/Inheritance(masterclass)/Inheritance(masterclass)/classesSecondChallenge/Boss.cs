using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_masterclass_.classesSecondChallenge
{
    class Boss: Employee
    {
        //properties
        public string CompanyCar { get; set; }

        //constructor
        public Boss()
        {
            CompanyCar = "default car";
        }

        public Boss(string name, string firstName, double salary, string companyCar)
            :base(name, firstName, salary)
        {
            //this.Name = name;
            //this.FirstName = firstName;
            //this.Salary = salary;
            this.CompanyCar = companyCar;
        }

        //methods
        public void Lead()
        {
            Console.WriteLine("{0} is the boss.", FirstName);
        }

    }
}
