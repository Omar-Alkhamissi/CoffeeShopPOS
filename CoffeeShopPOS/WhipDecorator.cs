using System;

namespace CoffeeShopPOS
{
    public class WhipDecorator : DrinkDecorator
    {
        public WhipDecorator(Drink inner) : base(inner) { }

        /*Method Name: Prepare
         *Purpose: Prepare wrapped drink then print whip add-on.
         *Accepts: none
         *Returns: void
         */
        public override void Prepare()
        {
            inner.Prepare();
            Console.WriteLine("[Decorator] Adding Whip...");
        }

        /*Method Name: Cost
         *Purpose: Return wrapped cost + 0.40m.
         *Accepts: none
         *Returns: decimal
         */
        public override decimal Cost() => inner.Cost() + 0.40m;

        /*Method Name: Description
         *Purpose: Append Whip text to wrapped description.
         *Accepts: none
         *Returns: string
         */
        public override string Description() => inner.Description() + ", Whip";
    }
}