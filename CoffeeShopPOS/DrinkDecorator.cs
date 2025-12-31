/**
 * Class Name: DrinkDecorator
 * Purpose: Abstract base for all condiment decorators; wraps another Drink.
 * Coder: Omar Alkhamissi
 * Date: 2025-07-17
 */

using System;
using System.Reflection;

namespace CoffeeShopPOS
{
    public abstract class DrinkDecorator : Drink
    {
        protected readonly Drink inner;

        // We must call Drink base ctor with an IBrewer. The wrapped drink already has one.
        // Because the brewer field in another Drink instance is protected, we obtain it via reflection
        protected DrinkDecorator(Drink inner) : base(GetBrewer(inner))
        {
            this.inner = inner;
        }

        private static IBrewer GetBrewer(Drink d)
        {
            var fld = typeof(Drink).GetField("brewer", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.FlattenHierarchy);
            return (IBrewer)fld.GetValue(d)!;
        }

        /*Method Name: Prepare
         *Purpose: Implemented by concrete decorators; call wrapped drink then add condiment behavior.
         *Accepts: none
         *Returns: void
         */
        public override abstract void Prepare();

        /*Method Name: Cost
         *Purpose: Implemented by concrete decorators; add condiment cost to wrapped drink cost.
         *Accepts: none
         *Returns: decimal
         */
        public override abstract decimal Cost();

        /*Method Name: Description
         *Purpose: Implemented by concrete decorators; append condiment text.
         *Accepts: none
         *Returns: string
         */
        public override abstract string Description();
    }
}