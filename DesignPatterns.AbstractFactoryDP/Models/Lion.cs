using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryDP.Models
{
    public class Lion : IAnimal
    {
        public string Speak()
        {
            return "Roar roar";
        }
    }
}
