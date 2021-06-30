using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class MashroomDecorator : PizzaDecorator
    {
        public MashroomDecorator(IPizza pizza) : base(pizza) { }
        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += ", with extra mashroom";
            return type;
        }
    }
}
