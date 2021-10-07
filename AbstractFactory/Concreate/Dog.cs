using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concreate
{
    public class Dog : IAnimal
    {
        public string Sepeak()
        {
            return $"Dog Bark like Bow bow -{nameof(Dog)} ";
        }
    }
}
