using System;

namespace CoffeeShopPOS
{
    public interface IOrderState
    {
        /*Method Name: Handle
         *Purpose: Execute state behavior and transition CoffeeShop to next state.
         *Accepts: CoffeeShop shop – context.
         *Returns: void
         */
        void Handle(CoffeeShop shop);
    }
}