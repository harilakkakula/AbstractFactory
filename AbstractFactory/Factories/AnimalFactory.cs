using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
  public abstract  class AnimalFactory
    {
        public abstract IAnimal Getanimal(string animal);

        public static AnimalFactory CreateAnimalFactory(string factorytype)
        {
            if (factorytype.Equals("sea"))
                return new SeaAnimalFactory();
            return new LandAnimalFactory();
        }
    }
}
