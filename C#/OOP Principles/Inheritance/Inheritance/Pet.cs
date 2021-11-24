using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // Derived class
    abstract class Pet : Animal
    {
        protected string name;
        protected string owner;
        protected string petType;

        public void readCollar()
        {
            Console.WriteLine("My name is {0} and my owner is {1}. I am a {2}", this.name, this.owner, this.petType);
        }

        public abstract void communicate();
    }
}