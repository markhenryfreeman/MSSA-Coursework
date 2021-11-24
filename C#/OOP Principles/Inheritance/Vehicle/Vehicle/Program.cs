using System;

namespace Shape
{
    class Program
    {
        private static void Main(string[] args)
        {
            Right t1 = new Right();
            t1.Width = 8.0;
            t1.Height = 12.0;
            t1.Style = "right";

            Console.WriteLine("Info for t1: ");
            t1.ShowStyle();
            t1.ShowDim();
            Console.WriteLine("Area is " + t1.Area());
        }
    }
}
