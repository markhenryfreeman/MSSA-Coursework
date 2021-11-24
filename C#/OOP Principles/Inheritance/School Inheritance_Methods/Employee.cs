using System;

namespace School
{
    class Employee
    {
        // Fields
        private int employeeId;

        // Constructor
        public Employee (ref int employee) {
            employee++;
            this.employeeId = employee;
        }
    }
}
