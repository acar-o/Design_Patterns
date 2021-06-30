using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Titanium : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 750;
        }

        public string GetCardType()
        {
            return "Titanium";
        }

        public int GetCreditLimit()
        {
            return 17500;
        }
    }
}
