using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new();
            PizzaDecorator pizza1 = new(pizza);
            CheeseDecorator cheese = new(pizza1);
            MashroomDecorator mashroom = new(cheese);

            Console.WriteLine(mashroom.GetPizzaType());
        }
    }
}
