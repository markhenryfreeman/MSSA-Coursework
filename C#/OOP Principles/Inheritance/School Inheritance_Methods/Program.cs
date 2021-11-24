using System;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine(School.getStudents());
            Student student_1 = new Student(ref School.students);
            Student student_2 = new Student(ref School.students);
            Student student_3 = new Student(ref School.students);
            Student student_4 = new Student(ref School.students);
            Student student_5 = new Student(ref School.students);
            Console.WriteLine(School.getStudents());

            Console.WriteLine(School.getTeachers());
            Teacher teacher_1 = new Teacher(ref School.teachers);
            Teacher teacher_2 = new Teacher(ref School.teachers);
            Console.WriteLine(School.getTeachers());

            Console.WriteLine(School.getJanitors());
            Janitor janitor_1 = new Janitor(ref School.janitors);
            Console.WriteLine(School.getJanitors());

        }
    }
}
