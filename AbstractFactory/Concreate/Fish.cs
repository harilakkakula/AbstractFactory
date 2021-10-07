using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concreate
{
    public class Fish : IAnimal
    {
        public string Sepeak()
        {
           return $"I have Hear Fish Sound -{nameof(Fish)}";
        }
    }
}
