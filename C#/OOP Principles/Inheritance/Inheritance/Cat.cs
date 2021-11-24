using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // Derived class
    class Cat : Pet, IAnimal
    {
        public Cat(string voice = "meow", string name = "Garfield", string owner = "John", string petType = "Kitty")
        {
            this.voice = voice;
            this.name = name;
            this.owner = owner;
            this.petType = petType;
        }

        public int legs { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool tail { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool fur { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void communicate()
        {
            Console.WriteLine(this.voice);
        }
    }
}
