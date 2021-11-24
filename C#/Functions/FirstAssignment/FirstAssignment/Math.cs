using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment
{
    class Math
    {
        public void multiply()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("You are running program 3.");

            double number1 = 0;
            double number2 = 0;
            double result = 0;

            Console.WriteLine("Enter value for number 1:");
            number1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for number 2:");
            number2 = Double.Parse(Console.ReadLine());

            if (number1 == 0 || number2 == 0)
            {
                Console.WriteLine("The answer is 0\n");
            }
            else
            {
                result = number1 * number2;
                Console.WriteLine("The result is {0}\n", result);
            }
        }

        public void divide()
            {
              Console.BackgroundColor = ConsoleColor.DarkBlue;
              Console.ForegroundColor = ConsoleColor.White;
              Console.WriteLine("You are running program 4.");

              Console.WriteLine("Enter value for number 1:");
              float number1 = float.Parse(Console.ReadLine());
              Console.WriteLine("Enter value for number 2:");
              float number2 = float.Parse(Console.ReadLine());

                if (number2 == 0)
                {
                    Console.WriteLine("You cannot divide by 0.\n");
                }
                else
                {
                    float result = number1 / number2;
                    Console.WriteLine("The result is {0}\n", result);
                }
            }

        public void compare()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("You are running program 5.");

            Console.WriteLine("Enter value for number 1:");
            float number1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for number 2:");
            float number2 = float.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine("The larger number is {0}.\n", number1);
            }
            else if (number2 > number1)
            {
                Console.WriteLine("The larger number is {0}.\n", number2);
            }
            else
            {
                Console.WriteLine("The numbers are equal.\n");
            }
        }

        }
    }
