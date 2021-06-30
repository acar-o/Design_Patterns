using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string type)
        {
            ICreditCard creditCard = null;
            if (type.ToLower().Equals("titanium"))
            {
                creditCard = new Titanium();
            }
            else if (type.ToLower().Equals("platinum"))
            {
                creditCard = new Platinum();
            }
            else if (type.ToLower().Equals("moneybBack"))
            {
                creditCard = new MoneyBack();
            }
            else
            {
                Console.WriteLine("no card like that!");
            }
            return creditCard;
        }
    }
}
