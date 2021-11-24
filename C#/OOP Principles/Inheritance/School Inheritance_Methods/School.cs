using System;

namespace School
{
    class School
    {
        public static int students;

        // Constructor
        public School () 
        {
            students = 0;
            empoyees = 0;
            teachers = 0;
            janitors = 0;
        }

        // Method
        public static int getStudents() 
        {
            return students;
        }

        public static int getEmployees()
        {
            return employees;
        }

        public static int getTeachers()
        {
            return teachers;
        }
        
        public static int getJanitors()
        {
            return janitors;
        }


        // Amount of employees
        // Amount of teachers
        // Amount of janitors
    }
}
