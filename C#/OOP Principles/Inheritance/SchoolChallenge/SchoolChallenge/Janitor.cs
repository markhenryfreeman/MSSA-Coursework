using System;

namespace School
{
    class Janitor : Employee
    {
        // Fields
        private int id;

        // Constructor
        public Janitor (ref int janitor) 
        {
            janitor++;
            this.id = janitor;
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
    }
}
