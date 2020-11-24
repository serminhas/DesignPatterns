using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryDP.Models
{
    public interface ICreditCard
    {
        string GetCardTypes();
        decimal GetCreditLimit();
        decimal GetAnnualCharge();
    }

}
