using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.GenericRepositoryDP.Models
{
    public class Product : CoreEntity
    {
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
