using System;

public class AddOrSubtract
{
    //all parameters can be put in the ().
    public static int Calculate(int firstNumber, int secondNumber, int result)
    {
        if (firstNumber <= secondNumber)
        {
            result = firstNumber + secondNumber;
            return result;
        }
        else
        {
            result = firstNumber - secondNumber;
            return result;
        }
        //if there is no else, you need a return result.
        //the code will still see the else as a option and will look for something to return.
        //the error will be "not all code paths return a value"
    }
}
