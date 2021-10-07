using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concreate
{

    public class Cat : IAnimal
    {
        public string Sepeak()
        {
            return $"Cat is Sounds like Meawwow-{nameof(Cat)}";
        }
    }
}
