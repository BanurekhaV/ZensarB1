using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class LandAnimalFactory : AnimalFactory
    {
        public override Animal GetAnimal(string animalType)
        {
            if (animalType.Equals("Dog"))
            {
                return new Dog();
            }
            else if (animalType.Equals("Cat"))
            {
                return new Cat();
            }
            else if (animalType.Equals("Lion"))
            {
                return new Lion();
            }
            else
                return null;
        }
    }

    public class SeaAnimalFactory : AnimalFactory
    {
        public override Animal GetAnimal(string animalType)
        {
            if (animalType.Equals("Shark"))
            {
                return new Shark();
            }
            else if (animalType.Equals("Octopus"))
            {
                return new Octopus();
            }
            else return null;

        }
        class ConcreteAnimalFactory
        {
            static void Main()
            {                
                AnimalFactory animalFactory = null;
                Animal animal = null;
                string speak = null;
                //create sea factory objects
                animalFactory = AnimalFactory.CreateAnimalFactory("Sea");
                Console.WriteLine("Animal Factory Type :" + animalFactory.GetType().Name);
                Console.WriteLine();
                //get octopus
                animal = animalFactory.GetAnimal("Octopus");
                Console.WriteLine("Animal Type :" + animal.GetType().Name);
                speak = animal.speak();
                Console.WriteLine(animal.GetType().Name + "Speak:" + speak);
                Console.WriteLine();
                //create Land factory objects
                animalFactory = AnimalFactory.CreateAnimalFactory("Land");
                Console.WriteLine("Animal Factory Type :" + animalFactory.GetType().Name);
                Console.WriteLine();
                //get octopus
                animal = animalFactory.GetAnimal("Lion");
                Console.WriteLine("Animal Type :" + animal.GetType().Name);
                speak = animal.speak();
                Console.WriteLine(animal.GetType().Name + "Speak:" + speak);
                Console.WriteLine();
                Console.Read();
            }
        }
    }
}
