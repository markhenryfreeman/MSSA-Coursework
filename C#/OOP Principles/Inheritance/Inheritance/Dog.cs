using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // Derived class
    class Dog : Pet
    {
        public Dog(string voice = "woof", string name = "Odie", string owner = "John", string petType = "Doggie")
        {
            this.voice = voice;
            this.name = name;
            this.owner = owner;
            this.petType = petType;
        }

        public override void communicate()
        {
            Console.WriteLine(this.voice);
        }
    }
}