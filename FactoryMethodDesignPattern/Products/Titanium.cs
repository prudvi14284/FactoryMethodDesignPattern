using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.Products
{
    //Concrete product class
    public class Titanium : CreditCard // Implement the credit card interface
    {
        public string GetCardType()
        {
            return "Titanium Edge";
        }

        public int GetCreditLimit()
        {
            return 25000;
        }

        public int GetCreditAnnulCharge()
        {
            return 1000;
        }
    }
}
