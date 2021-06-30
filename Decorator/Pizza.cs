using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Pizza : IPizza
    {
        public virtual string GetPizzaType()
        {
            return "Margarita";
        }
    }
}
