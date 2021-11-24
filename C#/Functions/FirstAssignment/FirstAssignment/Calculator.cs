using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment
{
    class Calculator
    {
        public void employeeIncome()
        {
            decimal annualSalary;
            decimal monthlyPay;
            decimal monthlyDeduction;
            decimal monthlySalary;

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("You are running program 1");
            Console.WriteLine("What is the employee's annual salary?");
            annualSalary = decimal.Parse(Console.ReadLine());
            monthlyPay = annualSalary / 12;
            Console.WriteLine("What is the employee's monthly deductions?");
            monthlyDeduction = decimal.Parse(Console.ReadLine());
            monthlySalary = monthlyPay - monthlyDeduction;
            Console.WriteLine("The employee makes ${0} per month\n", monthlySalary);
        }

        public void courseGrade()
        {
            double grade = 0;
            double total = 0;
            double average = 0;
            int gradeCounter = 0;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("You are running program 2.");
            Console.Out.WriteLine("Enter first grade");
            grade = Double.Parse(Console.ReadLine());
            while (grade != 200)
            {
                total = total + grade;
                gradeCounter++;
                Console.Out.WriteLine("Enter another grade or enter 200 to end.");
                grade = Double.Parse(Console.ReadLine());
            }
            if (gradeCounter != 0)
            {
                average = total / gradeCounter;
                Console.Out.WriteLine("Grade average is: {0}\n", average);
            }
            else
            {
                Console.Out.WriteLine("No grades were entered.\n");
            }
            if (average >= 70)
            {
                Console.WriteLine("Student Passed the Course!\n");
            }
            else
            {
                Console.WriteLine("The Student failed the course...\n");
            }
        }
    }
}
