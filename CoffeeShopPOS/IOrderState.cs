/**
 * Class Name: IOrderState
 * Purpose: State interface; each order state handles one stage in the workflow.
 * Coder: Omar Alkhamissi
 * Date: 2025-07-17
 */

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