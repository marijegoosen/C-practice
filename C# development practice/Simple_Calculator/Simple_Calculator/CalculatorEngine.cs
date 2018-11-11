using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    public class CalculatorEngine
    {
        /*class for calculating the inputs into a result
         * */

        public double Calculate (string operation, double firstNumber, double secondNumber)
        {
            //parameter for result
            double result;

            //switch statement used because there is only one parameter that has to be checked
            //ToLower is used to cast all operation to lowercase
            switch (operation.ToLower())
            {
                //if a result can come from 2 different options
                case "add":
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "substract":
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "multiply":
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "divide":
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                default:
                    //this is a exception, because there is something wrong. For documentation
                    throw new InvalidOperationException("Put in a correct operation (+, -, *, /)");
            }
                return result;
        }
    }
}
