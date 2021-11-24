using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Right : Triangle
    {
        public string Style; // style of triangle  
                               
        public void ShowStyle() // Display a triangle's style.
        {
            Console.WriteLine("Triangle is " + Style);
        }
 

    }
}
