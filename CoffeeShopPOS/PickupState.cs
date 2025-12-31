/**
 * Class Name: PickupState
 * Purpose: Final state; announce ready message; loop back to TakingOrderState.
 * Coder: Omar Alkhamissi
 * Date: 2025-07-17
 */

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