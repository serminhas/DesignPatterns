using System;

namespace DesignPatterns.FactoryDP.Models
{
    public class Gold : ICreditCard
    {
        public decimal GetAnnualCharge()
        {
            return 800;
        }

        public string GetCardTypes()
        {
            return "Gold Credit Card";
        }

        public decimal GetCreditLimit()
        {
            return 40000; 
        }
    }

}
