using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops__masterclass_
{
    class Program
    {
        static void Main(string[] args)
        {
            //a program that calculates the average score of students.
            //add each score individually and get the final score once enters -1. 
            //so check if number and add to sum.
            //afterwards the average score prints.
            //numbers entered 0 - 20. 
            //use prevention for incorrect value.

            double sum = 0;
            int score = 0;
            string input = "";
            int counter = 0;

            do
            {
                Console.WriteLine("Enter the score.");
                try
                {
                    input = Console.ReadLine();
                    score = int.Parse(input);
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a number between 0 and 20.");
                }


                if (score >= 0 && score <= 20)
                {
                    sum = sum + (double)score;
                    counter++;
                }
                else if(score == -1)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 0 and 20."); 
                }



            } while (score != -1);

            double average = sum / (double)counter;
            Console.WriteLine("There were {0} entries.", counter);
            Console.WriteLine("The sum is {0}", sum);
            Console.WriteLine("The average of the scores is {0}.", average);

            Console.ReadLine();
        }
    }
}
