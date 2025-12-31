/**
 * Class Name: PreparingState
 * Purpose: Prepare the selected drink and print cost; advance to PaymentState.
 * Coder: Omar Alkhamissi
 * Date: 2025-07-17
 */

using System;

namespace CoffeeShopPOS
{
    public class PreparingState : IOrderState
    {
        /*Method Name: Handle
         *Purpose: Call CurrentDrink.Prepare(), print cost, move to PaymentState.
         *Accepts: CoffeeShop shop – context.
         *Returns: void
         */
        public void Handle(CoffeeShop shop)
        {
            Console.WriteLine("--- Preparing Drink ---");
            shop.CurrentDrink.Prepare();
            Console.WriteLine($"Cost: ${shop.CurrentDrink.Cost():0.00}");
            shop.SetState(new PaymentState());
        }
    }
}