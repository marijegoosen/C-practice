//namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_Masterclass_
{
    class Program
    {
        //starting point of the program
        static void Main(string[] args)
        {
            //changes the text color and console color
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("Hello world");
            Console.Write("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
            Console.Read();

            /* This was a bit more complex
             * than what the exercise was.
             * This is interactive with the user.
             * */
        }
    }
}
