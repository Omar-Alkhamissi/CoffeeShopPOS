using System;

namespace CoffeeShopPOS
{
    class Program
    {
        /*Method Name: Main
         *Purpose: Run single full Point-of-Sale cycle: TakingOrder -> Preparing -> Payment -> Pickup.
         *Accepts: string[] args – command line args.
         *Returns: void
         */
        static void Main(string[] args)
        {
            CoffeeShop shop = new CoffeeShop();
            shop.Next(); // Taking order
            shop.Next(); // Preparing
            shop.Next(); // Payment
            shop.Next(); // Pickup
        }
    }
}