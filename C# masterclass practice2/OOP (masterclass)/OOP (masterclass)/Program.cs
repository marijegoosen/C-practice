using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__masterclass_
{
    class Program
    {
        static void Main(string[] args)
        {
            ////the long way of writting (no constructor)
            ////member variables need to be public
            //Human marije = new Human();
            //marije.firstName = "Marije";
            //marije.lastName = "Goosen";

            ////challenges during masterclass
            //Human marije = new Human("Marije", "Goosen", "brown", 26);
            //Human marije2 = new Human("Marije", "Goosen", "brown");
            //Human marije3 = new Human("Marije", "Goosen");
            //Human marije4 = new Human("Marije");
            //Human marije5 = new Human();

            //marije.IntroduceMyself();
            //marije2.IntroduceMyself();
            //marije3.IntroduceMyself();
            //marije4.IntroduceMyself();
            //marije5.IntroduceMyself();

            //Challenge properties
            //create a read only property "FrontSurface" which calculates the
            //front surface based on heigth and length.
            Box box1 = new Box(5, 5);
            Console.WriteLine("the front surface is {0}.", box1.FrontSurface);


            Console.Read();
        }
    }
}
