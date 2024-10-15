using System;

namespace PeksegSimulacio
{
    abstract class BakedGood : Product
    {
        public int Calories { get; private set; }

        public BakedGood(string name, decimal price, int calories)
            : base(name, price)
        {
            Calories = calories;
        }
    }
}