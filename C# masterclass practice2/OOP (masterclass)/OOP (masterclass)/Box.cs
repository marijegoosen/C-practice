using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__masterclass_
{
    class Box
    {
        private int height;
        private int length;
        private int frontSurface;

        public int FrontSurface
        {
            get => frontSurface = height * length;
        }

        public Box(int height, int length)
        {
            this.height = height;
            this.length = length;
        }


    }
}
