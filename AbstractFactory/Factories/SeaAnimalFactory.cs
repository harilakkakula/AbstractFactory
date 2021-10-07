using AbstractFactory.Concreate;
using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class SeaAnimalFactory : AnimalFactory
    {
        public override IAnimal Getanimal(string animal)
        {
            if (animal.Equals("Fish"))
                return new Fish();
            if (animal.Equals("Ocutopus"))
                return new Ocutopus();
            return null;

        }
    }
}
