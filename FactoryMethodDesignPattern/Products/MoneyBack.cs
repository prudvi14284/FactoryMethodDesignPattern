using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.Products
{
    //Concrete product class
    public class MoneyBack : CreditCard // Implement the credit card interface
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }

        public int GetCreditLimit()
        {
            return 15000;
        }

        public int GetCreditAnnulCharge()
        {
            return 500;
        }
    }
}
