using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.Products
{
    //Concrete product class
    public class Platinum : CreditCard // Implement the credit card interface
    {
        public string GetCardType()
        {
            return "Platinum Plus";
        }

        public int GetCreditLimit()
        {
            return 35000;
        }

        public int GetCreditAnnulCharge()
        {
            return 1500;
        }
    }
}
