using System;

namespace School
{
    class School
    {
        public static int students;
        public static int employees;
        public static int teachers;
        public static int janitors;
        public static int numOfClasses = Enum.GetNames(typeof(Classes)).Length;
        public static string[] listOfClasses = Enum.GetNames(typeof(Classes));
        public static string[] myClass = myClasses.myClass;

        // Constructor
        public School () 
        {
            students = 0;
            employees = 0;
            teachers = 0;
            janitors = 0;
            numOfClasses = Enum.GetNames(typeof(Classes)).Length;
            listOfClasses = Enum.GetNames(typeof(Classes));
        }

        // Method
        public static int getStudents() 
        {
            return students;
        }

        public static int getEmployees()
        {
            return (School.teachers + School.janitors);
        }

        public static int getTeachers()
        {
            return teachers;
        }
        
        public static int getJanitors()
        {
            return janitors;
        }

        public static int getNumClasses()
        {
            return numOfClasses;
        }
        
        public static void getListOfClasses()
        {
            Console.WriteLine("List of Classes: ");
            for (int i = 0; i < listOfClasses.Length; i++)
            {
                Console.WriteLine(listOfClasses[i]);
            }
        }

        public static void getListOfMyClasses()
        {
            Console.WriteLine("List of My Classes: ");
            foreach (string item in myClass)
            {
                Console.WriteLine(item);
            }
        }
    }
}
