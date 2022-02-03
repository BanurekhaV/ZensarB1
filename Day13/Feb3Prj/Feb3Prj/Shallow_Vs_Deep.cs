using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb3Prj
{

    class Person
    {
        public int Age;
        public PersonDescription desc; //composition

        public Person(int a, string fn, string ln)
        {
            Age = a;
            desc = new PersonDescription(fn, ln);
        }

        public Object ShallowCopy()
        {
            return this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person dcopy = new Person(this.Age, desc.FirstName, desc.LastName);
            return dcopy;
        }

    }

    class PersonDescription
    {
        public string FirstName;
        public string LastName;

        public PersonDescription(string f, string l)
        {
            this.FirstName = f;
            this.LastName = l;
        }
    }
    class Shallow_Vs_Deep
    {
        static void Main()
        {
            Person p1 = new Person(15, "Archana", "Gupta");
            //invoking Shallowcopy
            Person p2 = (Person)p1.ShallowCopy();
            //Console.WriteLine(p1.Age+" "+ p1.desc.FirstName);
            //Console.WriteLine(p2.Age +" " + p2.desc.FirstName);
            //p2.desc.FirstName = "Sakshi";
            //Console.WriteLine(p1.Age + " " + p1.desc.FirstName);
            //Console.WriteLine(p2.Age + " " + p2.desc.FirstName);
            //invoking Deepcopy
            Person p3 = p1.DeepCopy();
            Console.WriteLine(p1.desc.FirstName);
            Console.WriteLine(p3.desc.FirstName);
            p3.desc.FirstName = "Lalith";
            Console.WriteLine(p1.desc.FirstName);
            Console.WriteLine(p3.desc.FirstName);
            Console.WriteLine(p1.GetHashCode());
             Console.WriteLine( p3.GetHashCode());
            p2 = p1;
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p3.GetHashCode());
            Console.Read();  
        }
    }
}
