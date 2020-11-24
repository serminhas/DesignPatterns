using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryDP.Models
{
    public class Shark : IAnimal
    {
        public string Speak()
        {
            return "Can not speak";
        }
    }
}
