using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base (pizza) { }
        public override string GetPizzaType()
        {
            string type =  base.GetPizzaType();
            type += ", with extra cheese";
            return type;
        }
    }
}
