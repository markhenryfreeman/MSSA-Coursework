using System;
using System.Collections;
using System.Collections.Generic;

namespace School
{
    class Student
    {
        // Fields
        private int id;
        private string enrolledClass;
        Address aStudent;
        Contact cStudent;

        // Constructor
        public Student (ref int student) {
            student++;
            this.id = student;
            Console.WriteLine("What is your street name?");
            aStudent.street = Console.ReadLine();
            Console.WriteLine("What is your postal code?");
            aStudent.postal_code = Console.ReadLine();
            Console.WriteLine("What is your city?");
            aStudent.city = Console.ReadLine();
            Console.WriteLine("What is your house number?");
            aStudent.house_number = Console.ReadLine();
            Console.WriteLine("What is your apartment number?");
            aStudent.appartment_number = Console.ReadLine();
            Console.WriteLine("What is your phone number?");
            cStudent.phone_number = Console.ReadLine();
            Console.WriteLine("What is your email?");
            cStudent.email = Console.ReadLine();
        }

        public string getEmail()
        {
            return cStudent.email;
        }            

        public void enrollInMath()
        {
            enrolledClass = enrolledClass + Classes.Math;
            Console.WriteLine("Student is now enrolled in Math");
        }
        public void enrollInReading()
        {
            enrolledClass = enrolledClass + Classes.Reading;
            Console.WriteLine("Student is now enrolled in Reading");
        }
        public void enrollInHistory()
        {
            enrolledClass = enrolledClass + Classes.History;
            Console.WriteLine("Student is now enrolled in History");
        }
        public void enrollInScience()
        {
            enrolledClass = enrolledClass + Classes.Science;
            Console.WriteLine("Student is now enrolled in Science");
        }
        public void enrollInEnglish()
        {
            enrolledClass = enrolledClass + Classes.English;
            Console.WriteLine("Student is now enrolled in English");
        }


        //Generic Grade Conversion

   



    }
}
