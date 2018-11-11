using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_masterclass_
{
    class LittleChallenges
    {
        static void Method()
        {
            ////make a array that greets 5 friends
            //string[] friends = new string[5] { "Isa", "Rien", "Mark", "Chris", "Tilly"};

            //foreach (string f in friends)
            //{
            //    Console.WriteLine("Hello, {0} my friend", f);
            //}

            //challenge with multi-dimentional arrays
            //access the 7
            int[,] array2D = new int[,]
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };

            Console.WriteLine("{0}", array2D[2, 0]);

            Console.ReadKey();

            //create a jagged array, which contains 3 friends arrays, in which 2 family members should be stored

            string[][] familyOfFriends = new string[][]
            {
                new string[] {"Charlotte", "Marije"},
                new string[] {"Mark", "Tilly"},
                new string[] {"Andrew", "Stefan"}
            };

            Console.WriteLine("Hi, {0}, I would like to introduce {1} to you.", familyOfFriends[0][1], familyOfFriends[1][0]);
            Console.WriteLine("Hi, {0}, I would like to introduce {1} to you.", familyOfFriends[0][0], familyOfFriends[1][1]);
            Console.WriteLine("Hi, {0}, I would like to introduce {1} to you.", familyOfFriends[1][1], familyOfFriends[1][0]);
            Console.ReadLine();

            //create an array of happiness in the main method and assign 5 values to it
            //create a method which has an array (int) as its parameter
            //the method should increase the argument given by 2 for each entry
            //call the method in the main method ans use happiness as the argument
            //create a foreach loop to write all values onto the console.

            int[] happiness = new int[] { 1, 2, 3, 4, 5 };
            HappinessCalculator(happiness);

            foreach (int feeling in happiness)
            {
                Console.WriteLine("I feel a happiness of {0}", feeling);
            }

            Console.ReadLine();
        }

        //method for happiness
        public static void HappinessCalculator(int[] happinessCalc)
        {
            for (int i = 0; i < happinessCalc.Length; i++)
            {
                happinessCalc[i] += 2;
            }

        }
    }
}
