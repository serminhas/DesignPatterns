using System;

namespace DesignPatterns.FactoryDP.Models
{
    public class Silver : ICreditCard
    {
        public decimal GetAnnualCharge()
        {
            return 1200;
        }

        public string GetCardTypes()
        {
            return "Silver Credit Card";
        }

        public decimal GetCreditLimit()
        {
            return 80000;
        }
    }

}
