/**
 * Class Name: AutomaticMachine
 * Purpose: Concrete IBrewer implementor that simulates an automatic coffee machine.
 * Coder: Omar Alkhamissi
 * Date: 2025-07-17
 */

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