using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concreate
{
    public class Lion : IAnimal
    {
        public string Sepeak()
        {
            return $"Loin Sound like Roar -{nameof(Lion)} ";
        }
    }
}
