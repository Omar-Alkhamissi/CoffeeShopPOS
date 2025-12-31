/**
 * Class Name: TakingOrderState
 * Purpose: Gather brewer, base drink, and condiments; set CurrentDrink; advance to PreparingState.
 * Coder: Omar Alkhamissi
 * Date: 2025-07-17
 */

using System;
using System.Linq;

namespace CoffeeShopPOS
{
    public class TakingOrderState : IOrderState
    {
        /*Method Name: Handle
         *Purpose: Collect user input to build Drink and move to PreparingState.
         *Accepts: CoffeeShop shop – context.
         *Returns: void
         */
        public void Handle(CoffeeShop shop)
        {
            Console.WriteLine("--- Taking Order ---");

            // Brewer
            Console.WriteLine("Choose brewer (auto/manual):");
            string brewerIn = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();
            IBrewer brewer = brewerIn.StartsWith("a") ? new AutomaticMachine() : new ManualSteamer();

            // Drink
            Console.WriteLine("Choose drink (espresso/house):");
            string drinkIn = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();
            Drink drink = drinkIn.StartsWith("e") ? new Espresso(brewer) : new HouseBlend(brewer);

            // Condiments
            Console.WriteLine("Add condiments? (milk/syrup/whip, comma-separated or none):");
            string condIn = (Console.ReadLine() ?? string.Empty).Trim();
            if (!string.IsNullOrWhiteSpace(condIn) && !condIn.Equals("none", StringComparison.OrdinalIgnoreCase))
            {
                string[] parts = condIn.Split(',');
                foreach (var p in parts.Select(x => x.Trim().ToLowerInvariant()))
                {
                    if (p.StartsWith("m"))
                        drink = new MilkDecorator(drink);
                    else if (p.StartsWith("s"))
                        drink = new SyrupDecorator(drink);
                    else if (p.StartsWith("w"))
                        drink = new WhipDecorator(drink);
                }
            }

            shop.CurrentDrink = drink;
            shop.SetState(new PreparingState());
        }
    }
}