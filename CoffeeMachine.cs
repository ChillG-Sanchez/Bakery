using System;

namespace PeksegSimulacio
{
    abstract class CoffeeMachine : Product
    {
        public int Quantity { get; private set; } // ml-ben
        public int CaffeineContent { get; private set; } // mg-ban
        public bool HasMilkOrCream { get; private set; } // Tej vagy tejszínhab

        public CoffeeMachine(string name, decimal price, int quantity, int caffeineContent, bool hasMilkOrCream)
            : base(name, price)
        {
            Quantity = quantity;
            CaffeineContent = caffeineContent;
            HasMilkOrCream = hasMilkOrCream;
        }
    }
}