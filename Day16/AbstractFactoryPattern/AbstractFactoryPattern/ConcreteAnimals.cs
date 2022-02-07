using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Cat : Animal
    {
        public string speak()
        {
            return "Meow Meow";
        }
    }

    public class Dog : Animal
    {
        public string speak()
        {
            return "Bow Bow";
        }
    }

    public class Lion : Animal
    {
        public string speak()
        {
            return "Roar";
        }
    }
    public class Octopus : Animal
    {
        public string speak()
        {
            return "Squawck";
        }
    }

    public class Shark : Animal
    {
        public string speak()
        {
            return "I cannot Speak";
        }
    }
    
}
