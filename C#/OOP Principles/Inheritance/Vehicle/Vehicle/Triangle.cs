using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Triangle : Shape
    {
        public double Area() // Return area of triangle.
        {
            return Width * Height / 2;
        }

    }
}
