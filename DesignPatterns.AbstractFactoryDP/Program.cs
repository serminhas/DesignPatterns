using System;

namespace DesignPatterns.AbstractFactoryDP
{
    using Models;

    class Program
    {
        static void Main(string[] args)
        {
            IAnimal _animal;
            AnimalFactory _animalFactory = null;
            string _speak = null;

            _animalFactory = AnimalFactory.CreateAnimalFactory("Sea");
            Console.WriteLine("Animal Factory Type: " + _animalFactory.GetType().Name);
            Console.WriteLine();

            _animal = _animalFactory.GetAnimal("Octopus");
            Console.WriteLine("Animal Type: " + _animalFactory.GetType().Name);

            _speak = _animal.Speak();
            Console.WriteLine($"{ _animal.GetType().Name} Speak: {_speak}");
            Console.WriteLine(new String('-' , 50));
            Console.WriteLine();

            _animalFactory = AnimalFactory.CreateAnimalFactory("Land");
            Console.WriteLine("Animal Factory Type: " + _animalFactory.GetType().Name);
            Console.WriteLine();

            _animal = _animalFactory.GetAnimal("Dog");
            Console.WriteLine("Animal Type: " + _animalFactory.GetType().Name);

            _speak = _animal.Speak();
            Console.WriteLine($"{ _animal.GetType().Name} Speak: {_speak}");
            Console.WriteLine(new String('-', 50));
            Console.WriteLine();
        }
    }
}
