using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatypesAndVariables_Masterclass_
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 13;
            //int num2 = 100;
            //int sum = num1 / num2;

            //double d1 = 3.5;
            //double d2 = 5.89;
            //double sumD = d1 + d2;

            //float f1 = 3.5F;

            ////Use casting, otherwise error
            ////int divDandI = d1 / num2;

            //string myName = "Marije";
            //string capsName = myName.ToLower();

            ////implicit conversion
            //int num3 = 123659;
            //long bigNum = num3;

            ////explicit conversion
            //num2 = (int)d1;

            ////type Conversion
            //float myFloat = 13.37F;
            //string myString = myFloat.ToString();

            //Console.WriteLine("The sum of {0} and {1} = {2}.", num1, num2, sum);
            //Console.WriteLine("{0} devided by {1} is {2}.", d1, d2, sumD);
            //Console.WriteLine("My name is {0}.", capsName);

            //Console.WriteLine(myString);

            //Challange Datatypes and Variables
            byte byte1 = 6;
            SByte sbyte1 = -120;
            int num1 = 79;
            uint uNum1 = 4000000000;
            short short1 = -32;
            ushort uShort1 = 65;
            long long1 = 93739725;
            ulong uLong1 = 18399395352345;
            float float1 = 567.89F;
            double double1 = 784.789D;
            char char1 = 'r';
            bool bool1 = true;
            //decimal decimal1 = 1.0;
            string string1 = "I control text ";
            string string2 = "67";
            int stringToInt = int.Parse(string2);

            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11}", byte1, sbyte1, num1, uNum1
                , short1, uShort1, long1, uLong1, float1, double1
                , char1, bool1);
            Console.WriteLine(string1 + stringToInt);
            Console.Read();

            Console.Read();

        }
    }
}
