using System;

namespace CoffeeShopPOS
{
    public class AutomaticMachine : IBrewer
    {
        /*Method Name: Brew
         *Purpose: Print automatic brewing message.
         *Accepts: string description – drink description.
         *Returns: void
         */
        public void Brew(string description)
        {
            Console.WriteLine($"[Automatic] Brewing {description}...");
        }
    }
}