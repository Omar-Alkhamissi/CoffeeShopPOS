/**
 * Class Name: ManualSteamer
 * Purpose: Concrete IBrewer implementor that simulates manual steaming.
 * Coder: Omar Alkhamissi
 * Date: 2025-07-17
 */

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