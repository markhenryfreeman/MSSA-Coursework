using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Grade<T>
    {
        //Fields
        private string grade;

        //Constructors

        public void addGrade(string grade) //recieves value to store the field
        {
            this.grade = grade;
        }

        public string printGrade (string version)
        {
            return convertGrade(version)
        }

        public void mexicanNote();

        public void americanNote();

    }
}
