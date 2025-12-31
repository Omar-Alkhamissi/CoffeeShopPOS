/**
 * Class Name: MilkDecorator
 * Purpose: Adds Milk condiment (+$0.30) to a Drink.
 * Coder: Omar Alkhamissi
 * Date: 2025-07-17
 */

using System;

namespace CoffeeShopPOS
{
    public class MilkDecorator : DrinkDecorator
    {
        public MilkDecorator(Drink inner) : base(inner) { }

        /*Method Name: Prepare
         *Purpose: Prepare wrapped drink then print milk add-on.
         *Accepts: none
         *Returns: void
         */
        public override void Prepare()
        {
            inner.Prepare();
            Console.WriteLine("[Decorator] Adding Milk...");
        }

        /*Method Name: Cost
         *Purpose: Return wrapped cost + 0.30m.
         *Accepts: none
         *Returns: decimal
         */
        public override decimal Cost() => inner.Cost() + 0.30m;

        /*Method Name: Description
         *Purpose: Append Milk text to wrapped description.
         *Accepts: none
         *Returns: string
         */
        public override string Description() => inner.Description() + ", Milk";
    }
}