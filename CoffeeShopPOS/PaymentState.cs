/**
 * Class Name: PaymentState
 * Purpose: Collect payment until enough funds; print change; advance to PickupState.
 * Coder: Omar Alkhamissi
 * Date: 2025-07-17
 */

using System;

namespace CoffeeShopPOS
{
    public class PaymentState : IOrderState
    {
        /*Method Name: Handle
         *Purpose: Take payment input loop; validate; transition to PickupState.
         *Accepts: CoffeeShop shop – context.
         *Returns: void
         */
        public void Handle(CoffeeShop shop)
        {
            Console.WriteLine("--- Payment ---");
            decimal cost = shop.CurrentDrink.Cost();
            while (true)
            {
                Console.WriteLine("Enter payment amount: $");
                string? input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    continue;

                input = input.Trim();
                if (input.StartsWith("$"))
                    input = input.Substring(1);

                if (!decimal.TryParse(input, out decimal amt))
                    continue;

                if (amt < cost)
                {
                    Console.WriteLine("Insufficient amount. Try again.");
                    continue;
                }

                Console.WriteLine("Payment accepted.");
                decimal change = amt - cost;
                if (change > 0)
                    Console.WriteLine($"Change: ${change:0.00}");

                shop.SetState(new PickupState());
                break;
            }
        }
    }
}