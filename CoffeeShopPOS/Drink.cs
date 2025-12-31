/**
 * Class Name: Drink
 * Purpose: Bridge abstraction + Decorator component; base for all beverages.
 * Coder: Omar Alkhamissi
 * Date: 2025-07-17
 */

using System;

namespace CoffeeShopPOS
{
    public abstract class Drink
    {
        // Bridge reference to implementor.
        protected IBrewer brewer;

        // Constructor (no comment block required per rules).
        protected Drink(IBrewer brewer)
        {
            this.brewer = brewer;
        }

        /*Method Name: Prepare
         *Purpose: Prepare/brew this drink (implemented by subclasses).
         *Accepts: none
         *Returns: void
         */
        public abstract void Prepare();

        /*Method Name: Cost
         *Purpose: Get total cost of this drink (including decorators).
         *Accepts: none
         *Returns: decimal – cost in dollars.
         */
        public abstract decimal Cost();

        /*Method Name: Description
         *Purpose: Get human-readable description (including decorators).
         *Accepts: none
         *Returns: string – description text.
         */
        public abstract string Description();
    }
}