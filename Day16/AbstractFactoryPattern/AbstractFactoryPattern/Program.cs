using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public interface Animal
    {
        string speak();
    }

    public abstract class AnimalFactory
    {
        public abstract Animal GetAnimal(string animalType);
        public static AnimalFactory CreateAnimalFactory(string factoryType)
        {
            if (factoryType.Equals("Sea"))
            {
                return new SeaAnimalFactory();
            }
            else return new LandAnimalFactory();
        }
    }


}
