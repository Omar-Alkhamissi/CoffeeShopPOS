using System;

namespace CoffeeShopPOS
{
    public class CoffeeShop
    {
        private IOrderState state;
        public Drink CurrentDrink { get; set; }

        // Constructor: start in TakingOrderState.
        public CoffeeShop()
        {
            state = new TakingOrderState();
        }

        /*Method Name: SetState
         *Purpose: Change current IOrderState.
         *Accepts: IOrderState newState – new workflow stage.
         *Returns: void
         */
        public void SetState(IOrderState newState)
        {
            state = newState;
        }

        /*Method Name: Next
         *Purpose: Invoke current state's Handle() passing this context.
         *Accepts: none
         *Returns: void
         */
        public void Next()
        {
            state.Handle(this);
        }
    }
}