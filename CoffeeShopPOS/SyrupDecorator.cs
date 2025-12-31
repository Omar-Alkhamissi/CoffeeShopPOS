/**
 * Class Name: SyrupDecorator
 * Purpose: Adds Syrup condiment (+$0.50) to a Drink.
 * Coder: Omar Alkhamissi
 * Date: 2025-07-17
 */

using System;

namespace CoffeeShopPOS
{
    public class SyrupDecorator : DrinkDecorator
    {
        public SyrupDecorator(Drink inner) : base(inner) { }

        /*Method Name: Prepare
         *Purpose: Prepare wrapped drink then print syrup add-on.
         *Accepts: none
         *Returns: void
         */
        public override void Prepare()
        {
            inner.Prepare();
            Console.WriteLine("[Decorator] Adding Syrup...");
        }

        /*Method Name: Cost
         *Purpose: Return wrapped cost + 0.50m.
         *Accepts: none
         *Returns: decimal
         */
        public override decimal Cost() => inner.Cost() + 0.50m;

        /*Method Name: Description
         *Purpose: Append Syrup text to wrapped description.
         *Accepts: none
         *Returns: string
         */
        public override string Description() => inner.Description() + ", Syrup";
    }
}