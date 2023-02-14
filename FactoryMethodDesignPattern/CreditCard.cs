using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    //Product Interface
    public interface CreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetCreditAnnulCharge();
    }
}
