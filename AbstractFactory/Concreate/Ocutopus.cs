using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concreate
{
    public class Ocutopus : IAnimal
    {
        public string Sepeak()
        {
            return $"I haven't hear the ocutopus ound Sweeks {nameof(Ocutopus)}";
        }
    }
}
