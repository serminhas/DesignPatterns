using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryDP.Models
{
    public class Dog : IAnimal
    {
        public string Speak()
        {
            return "Hav Hav";
        }
    }
}
