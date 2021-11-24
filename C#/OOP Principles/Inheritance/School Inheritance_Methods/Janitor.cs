using System;

namespace School
{
    class Janitor
    {
        // Fields
        private int id;

        // Constructor
        public Janitor (ref int janitor) {
            janitor++;
            this.id = janitor;
        }
    }
}
