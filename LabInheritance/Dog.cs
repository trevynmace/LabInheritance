using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabInheritance
{
    public class Dog : Pet
    {
        public Dog(string name) : base(name) { }

        public override string Communicate()
        {
            return "bark";
        } 

    }
}
