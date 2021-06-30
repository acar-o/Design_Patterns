using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class PizzaDecorator : Pizza
    {
        private IPizza _pizza;
        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }
        public override string GetPizzaType()
        {
            return _pizza.GetPizzaType();
        }
    }
}
