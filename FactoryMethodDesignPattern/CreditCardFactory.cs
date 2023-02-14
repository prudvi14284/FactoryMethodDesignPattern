using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    //Abstract Creator
    public abstract class CreditCardFactory
    {
        //Abstract Method
        protected abstract CreditCard MakeProduct();

        //Concrete Method
        public CreditCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }
}
