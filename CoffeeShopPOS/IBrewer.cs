/**
 * Class Name: IBrewer
 * Purpose: Implementor side of Bridge; anything that can brew a drink description.
 * Coder: Omar Alkhamissi
 * Date: 2025-07-17
 */

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