using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryDP.Models
{
    public class Octopus : IAnimal
    {
        public string Speak()
        {
            return "SQUAWCCK";
        }
    }
}
