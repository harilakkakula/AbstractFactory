using AbstractFactory.Factories;
using AbstractFactory.Interface;
using System;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = null;
            AnimalFactory animlafactory = null;
            string sound = null;

            animlafactory=AnimalFactory.CreateAnimalFactory("sea");
            animal=animlafactory.Getanimal("Fish");
            sound=animal.Sepeak();
            Console.WriteLine($"The sound of Fish is {sound}");
            Console.ReadLine();

        }

        public override bool Equals(object obj)
        {
#pragma warning disable S3249 // Classes directly extending "object" should not call "base" in "GetHashCode" or "Equals"
            return base.Equals(obj);
#pragma warning restore S3249 // Classes directly extending "object" should not call "base" in "GetHashCode" or "Equals"
        }

        public override int GetHashCode()
        {
#pragma warning disable S3249 // Classes directly extending "object" should not call "base" in "GetHashCode" or "Equals"
            return base.GetHashCode();
#pragma warning restore S3249 // Classes directly extending "object" should not call "base" in "GetHashCode" or "Equals"
        }
    }
}
