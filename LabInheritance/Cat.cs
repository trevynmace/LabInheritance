using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabInheritance
{
    public class Cat : Pet
    {
        public Cat(string name) : base(name) { }

        public override string Communicate()
        {
            return "meow";
        }
    }
}
