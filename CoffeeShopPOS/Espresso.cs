/**
 * Class Name: Espresso
 * Purpose: Concrete Drink representing an espresso beverage.
 * Coder: Omar Alkhamissi
 * Date: 2025-07-17
 */

using System;

namespace CoffeeShopPOS
{
    public class Espresso : Drink
    {
        public Espresso(IBrewer brewer) : base(brewer) { }

        /*Method Name: Prepare
         *Purpose: Brew the espresso via the associated IBrewer.
         *Accepts: none
         *Returns: void
         */
        public override void Prepare()
        {
            brewer.Brew(Description());
        }

        /*Method Name: Cost
         *Purpose: Return base espresso cost.
         *Accepts: none
         *Returns: decimal 2.00m
         */
        public override decimal Cost() => 2.00m;

        /*Method Name: Description
         *Purpose: Return beverage description.
         *Accepts: none
         *Returns: string "Espresso"
         */
        public override string Description() => "Espresso";
    }
}