using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Shape
    {
        public double Width;
        public double Height;
        public void ShowDim()
        {
            Console.WriteLine($"Width is {Width} and height is {Height}.");
        }
    }
}
