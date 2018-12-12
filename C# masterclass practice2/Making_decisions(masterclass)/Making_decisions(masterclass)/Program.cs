using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_decisions_masterclass_
{
    class Program
    {
        ////variables for challenge if statements
        //static string username, password;
        //static string username2, password2;

        ////variables for challenge if statements 2
        //static string playerName;
        //static string highscoreString;
        //static int highscore;

        static void Main(string[] args)
        {
            ////first try if statements. Looks better then the one in the masterclass
            //string temperature = Console.ReadLine();
            //int temperature1 = int.Parse(temperature);

            //if (temperature1 <= 10)
            //{
            //    Console.WriteLine("stay at home. Too cold");
            //}
            //else if (temperature1 <= 15)
            //{
            //    Console.WriteLine("take a coat");
            //}
            //else if (temperature1 <= 22)
            //{
            //    Console.WriteLine("Warm & cozy");
            //}
            //else
            //{
            //    Console.WriteLine("too warm.");
            //}

            //////challenge if statements
            ////create a user login system;

            ////user registers and is loged in.
            //FirstRegister();

            //Console.WriteLine("username = {0}, password = {1}", username, password);

            ////check if user has entered correct username and password
            //CheckLogIn();

            ////switch statemens written as a if statement
            //int age = 26;
            //switch (age)
            //{
            //    case 15:
            //        Console.WriteLine("Too young to party in the club.");
            //        break;
            //    case 25:
            //        Console.WriteLine("Good to go.");
            //        break;
            //    default:
            //        Console.WriteLine("How old are you then?");
            //        break;
            //}

            //if(age == 15)
            //{
            //    Console.WriteLine("Too young to party in the club.");
            //}
            //else if (age == 25)
            //{
            //    Console.WriteLine("Good to go.");
            //}
            //else
            //{
            //    Console.WriteLine("How old are you then?");
            //}

            ////challenge if statements 2: an application with a score, highscore and a highscoreplayer.
            //string newHighscoreString = "100";
            //int newHighscore = int.Parse(newHighscoreString);
            //string newHighscorePlayer = "Jos";

            ////when method is called, check if score is higher than highscore
            //    NewPlayer();

            //    switch (highscore > newHighscore)
            //    {
            //        case true:
            //            Console.WriteLine("New highscore is {0} and new highscore holder is {1}.", highscore, playerName);
            //            newHighscore = highscore;
            //            newHighscorePlayer = playerName;
            //            break;
            //        case false:
            //            Console.WriteLine("Old highscore is {0} could not be broken and is still held by {1}.", newHighscore, newHighscorePlayer);
            //            break;
            //        default:
            //            Console.WriteLine("The highscores are equal. The old highscore stands at {0} and is still held by {1}", newHighscore, newHighscorePlayer);
            //            break;
            //    }

            //enhanced if statement
            int temperature = -5;

            string stateOfMatter = temperature < 0 ? "solid" : (temperature < 100 ? "liquid" : "gas");
            Console.WriteLine("the state of matter is {0}", stateOfMatter);

            temperature = 101;
            stateOfMatter = temperature < 0 ? "solid" : (temperature < 100 ? "liquid" : "gas");
            Console.WriteLine("the state of matter is {0}", stateOfMatter);

            Console.Read();
        }

        ////methods for challenge if statements
        ////method for first registers fir
        //public static void FirstRegister()
        //{
        //    Console.Write("Please choose a username: ");
        //    username = Console.ReadLine();
        //    Console.Write("Please choose a password: ");
        //    password = Console.ReadLine();

        //    if (username != "" && password != "")
        //    {
        //        Console.WriteLine("you are now loged in.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Please choose a username and password.");
        //    }
        //}

        ////method for checking the login
        //public static void CheckLogIn()
        //{
        //    Console.Write("Please type in username: ");
        //    username2 = Console.ReadLine();
        //    Console.Write("Please type in password: ");
        //    password2 = Console.ReadLine();

        //    if (username.Equals(username2) && password.Equals(password2))
        //    {
        //        Console.WriteLine("You are loggin in. Welcome {0}", username);
        //    }
        //    else if (username.Equals(username2))
        //    {
        //        Console.WriteLine("Username and password don't match.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Please fill in correct username and password");
        //    }
        //}

        ////method with 2 parameters (for the score and the playername)
        //public static void NewPlayer()
        //{
        //    Console.Write("Type in your username: ");
        //    playerName = Console.ReadLine();
        //    Console.Write("Type in your highscore: ");
        //    highscoreString = Console.ReadLine();

        //    try
        //    {
        //        highscore = int.Parse(highscoreString);
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("Not a valid highscore input. Highscore is set to 0.");
        //        highscoreString = "0";
        //        highscore = 0;
        //    }
        //    finally
        //    {
        //        highscore = highscore;
        //        playerName = playerName;
        //        highscoreString = highscoreString;
        //    }
        //}

    }
}
