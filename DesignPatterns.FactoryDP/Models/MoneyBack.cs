using System;

namespace DesignPatterns.FactoryDP.Models
{
    public class MoneyBack : ICreditCard
    {
        public decimal GetAnnualCharge()
        {
            return 500;
        }

        public string GetCardTypes()
        {
            return "MoneyBack Card";
        }

        public decimal GetCreditLimit()
        {
            return 2000;
        }
    }

}
