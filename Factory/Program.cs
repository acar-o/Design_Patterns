using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your credit card?");
            ICreditCard creditCard = CreditCardFactory.GetCreditCard(Console.ReadLine());
            Console.WriteLine(creditCard.GetCreditLimit());
            Console.WriteLine(creditCard.GetAnnualCharge());
        }
    }
}
