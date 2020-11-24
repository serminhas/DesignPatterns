using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryDP.Models
{
    public class Cat : IAnimal
    {
        public string Speak()
        {
           return "Meow meow";
        }
    }
}
