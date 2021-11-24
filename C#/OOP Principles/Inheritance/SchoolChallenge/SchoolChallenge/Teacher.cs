using System;

namespace School
{
    class Teacher : Employee
    {
        // Fields
        private int id;
        private string teachClass;

        // Constructor
        public Teacher (ref int teacher) 
        {
            teacher++;
            this.id = teacher;
            Console.WriteLine("What is your street name?");
            aEmployee.street = Console.ReadLine();
            Console.WriteLine("What is your postal code?");
            aEmployee.postal_code = Console.ReadLine();
            Console.WriteLine("What is your city?");
            aEmployee.city = Console.ReadLine();
            Console.WriteLine("What is your house number?");
            aEmployee.house_number = Console.ReadLine();
            Console.WriteLine("What is your apartment number?");
            aEmployee.appartment_number = Console.ReadLine();
            Console.WriteLine("What is your phone number?");
            cEmployee.phone_number = Console.ReadLine();
            Console.WriteLine("What is your email?");
            cEmployee.email = Console.ReadLine();
        }
    


    public void teachMath()
    {
        teachClass = teachClass + Classes.Math;
        Console.WriteLine("Teacher is now teaching Math");
    }
    public void teachReading()
    {
        teachClass = teachClass + Classes.Reading;
        Console.WriteLine("Teacher is now teaching Reading");
    }
    public void teachHistory()
    {
        teachClass = teachClass + Classes.History;
        Console.WriteLine("Teacher is now teaching History");
    }
    public void teachScience()
    {
        teachClass = teachClass + Classes.Science;
        Console.WriteLine("Teacher is now teaching Science");
    }
    public void teachEnglish()
    {
        teachClass = teachClass + Classes.English;
        Console.WriteLine("Teacher is now teaching English");
    }
}


}
