using AbstractFactory.Concreate;
using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    class LandAnimalFactory : AnimalFactory
    {
        public override IAnimal Getanimal(string animal)
        {
            if (animal.Equals("Lion"))
                return new Lion();
            if (animal.Equals("Cat"))
                return new Cat();
            if (animal.Equals("Dog"))
                return new Dog();
            return null;

        }
    }
}
