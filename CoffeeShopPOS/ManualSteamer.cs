using System;

namespace CoffeeShopPOS
{
    public class ManualSteamer : IBrewer
    {
        /*Method Name: Brew
         *Purpose: Print manual brewing message.
         *Accepts: string description – drink description.
         *Returns: void
         */
        public void Brew(string description)
        {
            Console.WriteLine($"[Manual] Brewing {description}...");
        }
    }
}