﻿using System;

namespace IceCream
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, i, k, count = 1;
            Console.Write("Enter number of rows\n");
            number = int.Parse(Console.ReadLine());

            count = 1;
            for (k = 1; k <= number - 1; k++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count++;
                for (i = 1; i <= 2 * (number - k) - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }

            //count = number - 1;
            //for (k = 1; k <= number; k++)
            //{
            //    for (i = 1; i <= count; i++)
            //        Console.Write(" ");
            //    count--;
            //    for (i = 1; i <= 2 * k - 1; i++)
            //        Console.Write("*");
            //    Console.WriteLine();
            //}



            Console.ReadLine();



        }
    }
}
