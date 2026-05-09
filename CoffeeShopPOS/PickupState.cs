using System;

namespace CoffeeShopPOS
{
    public class PickupState : IOrderState
    {
        /*Method Name: Handle
         *Purpose: Print ready/pickup message; transition to TakingOrderState.
         *Accepts: CoffeeShop shop – context.
         *Returns: void
         */
        public void Handle(CoffeeShop shop)
        {
            Console.WriteLine("--- Ready for Pickup ---");
            Console.WriteLine($"Enjoy your {shop.CurrentDrink.Description()}!");
            shop.SetState(new TakingOrderState());
        }
    }
}