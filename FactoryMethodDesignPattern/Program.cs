using FactoryMethodDesignPattern.ConcreteCreator;
using FactoryMethodDesignPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            CreditCard creditCard = new MoneyBackFactory().CreateProduct();
            if(creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Card Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charges : " + creditCard.GetCreditAnnulCharge());
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }
            Console.WriteLine("---------------------");

            creditCard = new PlatinumFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Card Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charges : " + creditCard.GetCreditAnnulCharge());
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }
            Console.WriteLine("---------------------");

            creditCard = new TitaniumFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Card Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charges : " + creditCard.GetCreditAnnulCharge());
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }
            Console.ReadKey();
        }
    }
}
