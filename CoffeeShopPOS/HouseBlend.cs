/**
 * Class Name: HouseBlend
 * Purpose: Concrete Drink representing house blend drip coffee.
 * Coder: Omar Alkhamissi
 * Date: 2025-07-17
 */

using System;

namespace CoffeeShopPOS
{
    public class HouseBlend : Drink
    {
        public HouseBlend(IBrewer brewer) : base(brewer) { }

        /*Method Name: Prepare
         *Purpose: Brew the house blend via the associated IBrewer.
         *Accepts: none
         *Returns: void
         */
        public override void Prepare()
        {
            brewer.Brew(Description());
        }

        /*Method Name: Cost
         *Purpose: Return base house blend cost.
         *Accepts: none
         *Returns: decimal 1.50m
         */
        public override decimal Cost() => 1.50m;

        /*Method Name: Description
         *Purpose: Return beverage description.
         *Accepts: none
         *Returns: string "House Blend Coffee"
         */
        public override string Description() => "House Blend Coffee";
    }
}