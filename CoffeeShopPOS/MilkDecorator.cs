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