using System;

namespace CoffeeShopPOS
{
    public interface IBrewer
    {
        /*Method Name: Brew
         *Purpose: Perform/print brewing action for the given drink description.
         *Accepts: string description – human-readable drink text.
         *Returns: void
         */
        void Brew(string description);
    }
}