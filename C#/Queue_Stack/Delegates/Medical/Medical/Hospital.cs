using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical
{
    class Hospital
    {
        double WeightInKGs;
        double WeightInLBs;

        public void weightConversion()
        {
            double WeightInKGs = WeightInLBs * 0.45359237;
            Console.WriteLine($"Patient weight in pounds is {WeightInLBs}.");
            Console.WriteLine($"Patient weight in pounds is {WeightInKGs}.");
        }
    }
}
