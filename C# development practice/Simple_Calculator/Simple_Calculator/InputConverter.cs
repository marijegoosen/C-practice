using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    public class InputConverter
    {
        /* This class is meaned to convert the inputs from string to numeric values.
         * */
        
        public double ConvertInputToNumeric(string textInput)
        {
            double convertedNumber;

            //You don't have to make a different value for the TryParse; That can be done in the if-statement
            //checkes if the conversion is NOT true and throw an exception if so
            if (!double.TryParse(textInput, out convertedNumber)) throw new ArgumentException("Expected a numeric value.");
            return convertedNumber;
        }
    }
}
