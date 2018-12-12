using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__masterclass_
{
    class Human
    {
        //member variables
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        //constructor
        public Human()
        {
            Console.WriteLine("Please fill in the parameters. This is an empty constructor.");
        }

        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public void IntroduceMyself()
        {
            if (age != 0 && eyeColor != null && lastName != null && firstName != null)
            {
                Console.WriteLine("My name is {0} {1}, I have {2} eyes and am {3} years old.", firstName, lastName, eyeColor, age);
            }
            else if (eyeColor != null && lastName != null && firstName != null)
            {
                Console.WriteLine("My name is {0} {1}, I have {2} eyes.", firstName, lastName, eyeColor);
            }
            else if (lastName != null && firstName != null)
            {
                Console.WriteLine("My name is {0} {1}.", firstName, lastName);
            }
            else if (firstName != null)
            {
                Console.WriteLine("My name is {0}.", firstName);
            }
            else
            {
                Console.WriteLine("This person did not give information");
            }
        }
    }
}
