using Inheritance_masterclass_.classesSecondChallenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_masterclass_
{
    //first challenge
    //add a deriving class VideoPost with a property VideoURL, Length
    //create the required constructors to create a VideoPost
    //adjust the ToString() method accordingly
    //create an instance of VideoPost and use the ToString method on it
    //make a Play method and a Stop method

    //second challenge
    //Create a main class with a Main Method, then a base class Employee with the properties Name, FirstName, Salary and the methods Work() and Pause().
    //Create a deriving class boss with the propertie CompanyCar and the method Lead(). 
    //Create another deriving class of employees - trainees with the properties WorkingHours and SchoolHourse and a method Learn().
    //Override the methods Work() of the trainee class so that it indicates the working hours of the trainee.
    //Don’t forget to create the constructors.
    //Create an object of each of the three classes (with arbitrary values)
    //and call the methods, Lead() of Boss and Work() of Trainee.
    //Just print out the respective text, what the respective employees do.

    class Program
    {
        static void Main(string[] args)
        {
            ////first challenge
            ////calls default constructor
            ////Post post = new Post();

            //Post post1 = new Post("Thanks for the birthday wishes", true, "Marije Goosen");
            //Console.WriteLine(post1.ToString());

            //ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Marije Goosen", "https://images.com/shoes", true);
            //Console.WriteLine(imagePost1.ToString());

            //VideoPost videoPost1 = new VideoPost("My first video", "Marije Goosen", "https://google.com", 5, true);
            //Console.WriteLine(videoPost1.ToString());

            ////part of the more challeging stuff
            //videoPost1.Play();
            //Console.WriteLine("Press any key to stop the video");
            //Console.ReadKey();
            //videoPost1.Stop();

            ////second challenge
            //Employee marije = new Employee("Goosen", "Marije", 2000);
            //marije.Work();
            //marije.Pauze();

            //Boss rien = new Boss( null, "Rien", 5000, "Mercedus");
            //rien.Lead();

            //Trainee ruben = new Trainee("Gartner", "Michelle", 1000, 4, 4);
            //ruben.Work();
            //ruben.Learn();

            Notification n1 = new Notification("Marije", "Hello World", "15-8-2018");
            Notification n2 = new Notification("World", "Hello back", "15-8-2018");

            n1.showNotifications();
            n2.showNotifications();

            Console.ReadLine();
        }
    }

    public interface INotifications
    {
        //members
        void showNotifications();
        string getDate();
    }

    public class Notification : INotifications
    {
        private string sender;
        private string message;
        private string date;

        public Notification()
        {
            sender = "Admin";
            message = "default message";
            date = " ";
        }

        public Notification(string mySender, string myMessage, string myDate)
        {
            this.sender = mySender;
            this.message = myMessage;
            this.date = myDate;
        }

        public string getDate()
        {
            return date;
        }

        public void showNotifications()
        {
            Console.WriteLine("Message: {0} - was sent by {1} - at {2}", message, sender, date );
        }
    }
}
