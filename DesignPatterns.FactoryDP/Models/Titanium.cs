using System;

namespace DesignPatterns.FactoryDP.Models
{
    public class Titanium : ICreditCard
    {
        public decimal GetAnnualCharge()
        {
            return 1400;
        }

        public string GetCardTypes()
        {
            return "Titanium Credit Card";
        }

        public decimal GetCreditLimit()
        {
            return 100000;
        }
    }

}
