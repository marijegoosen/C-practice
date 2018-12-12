using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challengeMasterclassMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string friend1 = "Isa";
            //string friend2 = "Chris";
            //string friend3 = "Peter";
            //GreetFriend(friend1);
            //GreetFriend(friend2);
            //GreetFriend(friend3);

            ////Challenge Masterclass methods
            //Console.Write("choose the first number: ");
            //string stringNum1 = Console.ReadLine();
            //Console.Write("choose the operator: ");
            //string operator1 = Console.ReadLine();
            //Console.Write("choose the second number: ");
            //string stringNum2 = Console.ReadLine();

            //int num1 = int.Parse(stringNum1);
            //int num2 = int.Parse(stringNum2);

            //Console.WriteLine("The result is ", Calculator(num1, num2, operator1));

            Console.Write("Please enter a number: ");
            string userInput1 = Console.ReadLine();
            Console.Write("Please enter a second number: ");
            string userInput2 = Console.ReadLine();
            int userInputAsInt1 = int.Parse(userInput1);
            int userInputAsInt2 = int.Parse(userInput2);

            try
            {
                int result = userInputAsInt1 / userInputAsInt2;
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("overflow exception.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Argument null exception.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZero exception.");
            }
            catch (Exception)
            {
                Console.WriteLine("General exception.");
            }
            finally
            {
                Console.WriteLine("This is called anyways.");
            }

            Console.ReadLine();
        }

        //public static void GreetFriend(string friendName)
        //{
        //    Console.WriteLine("Hi {0}, my friend", friendName);
        //}

        //public static int Calculator(int num1, int num2, string operator1)
        //{
        //    int result;

        //    if (operator1 == "+")
        //    {
        //        result = num1 + num2;
        //        return result;
        //    }
        //    else if (operator1 == "-")
        //    {
        //        result = num1 - num2;
        //        return result;
        //    }
        //    else if (operator1 == "*")
        //    {
        //        result = num1 * num2;
        //        return result;
        //    }
        //    else if (operator1 == "/")
        //    {
        //        result = num1 / num2;
        //        return result;
        //    }
        //    else
        //    {
        //        result = 0;
        //        return result;
        //    }
        //}
    }
}

