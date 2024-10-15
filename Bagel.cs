using System;

namespace PeksegSimulacio
{
    class Bagel : BakedGood
    {
        public string Topping { get; private set; }

        public Bagel(string name, decimal price, int calories, string topping)
            : base(name, price, calories)
        {
            Topping = topping;
        }

        public override string GetDescription()
        {
            return $"{Name} ({Topping}) - Ár: {Price} Ft, Kalória: {Calories} kcal";
        }

        public override void IncreasePrice(decimal amount)
        {
            Price += 30;
        }
    }
}