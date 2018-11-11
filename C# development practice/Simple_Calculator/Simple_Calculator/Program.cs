using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Sometimes it is good to write things that are not there yet.
             * Make placeholders for those things instead. Like writing the InputConverter line before making the class for it.
             * This is kinda like test-driven development, because you make the backbone first
             * the errors will go away if you put the right code for the placeholders.
             * 
             * Single responsibility principle = cutting the code in pieces for more overview
             * 
             * There will be an exception when the input is not numeric. To catch this, put all code in a try-catch statement.
             */

            string answer;
            do
            {
                try
                {
                    //inputconverter for converting the input from string to a numeric type
                    InputConverter inputConverter = new InputConverter();
                    //engine to do the calculation
                    CalculatorEngine calculatorEngine = new CalculatorEngine();

                    //to get the inputs
                    //the inputs are double to account for floating point numbers
                    //Console.ReadLine = parameter
                    //ConvertInputToNumeric = method that converts the input
                    Console.Write("Type in a first number: ");
                    double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                    Console.Write("Type in a second number: ");
                    double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                    Console.Write("Type in a operator: ");
                    string operation = Console.ReadLine();

                    /* To perform the calculation and store the result of the calculation in a variable.
                     * Calculate = method that calculates and will have 3 parameters.
                     */
                    double result = calculatorEngine.Calculate(operation, secondNumber, firstNumber);

                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    // In real world we would want to log this message
                    //TODO: start logging exceptions
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Do you want to continue: ");
                    answer = Console.ReadLine();
                }
            }
            while (answer == "yes");
        }
    }
}
