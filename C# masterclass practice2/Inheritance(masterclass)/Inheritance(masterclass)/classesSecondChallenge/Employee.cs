using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_masterclass_.classesSecondChallenge
{

    class Employee
    {
        //properties
        public string Name { get;set;}
        public string FirstName { get; set; }
        public double Salary { get; set; }

        //constructor
        public Employee()
        {
            Name = "default name";
            FirstName = "default name";
            Salary = 2000;
        }

        public Employee(string name, string firstName, double salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        //methods
        public void Work()
        {
            Console.WriteLine("{0} is working.", FirstName);
        }


        public void Pauze()
        {
            Console.WriteLine("{0} is having a break.", FirstName);
        }


    }
}
