using System;

namespace DesignPatterns.FactoryDP.Models
{
    public class Platinum : ICreditCard
    {
        public decimal GetAnnualCharge()
        {
            return 1000;
        }

        public string GetCardTypes()
        {
            return "Platinum Credit Card";
        }

        public decimal GetCreditLimit()
        {
            return 60000;
        }
    }

}
