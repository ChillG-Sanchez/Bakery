using System;

namespace PeksegSimulacio
{
    class Muffin : BakedGood
    {
        public string Flavor { get; private set; }

        public Muffin(string name, decimal price, int calories, string flavor)
            : base(name, price, calories)
        {
            Flavor = flavor;
        }

        public override string GetDescription()
        {
            return $"{Name} ({Flavor}) - Ár: {Price} Ft, Kalória: {Calories} kcal";
        }

        public override void IncreasePrice(decimal amount)
        {
            Price += Price * 0.10m;
        }
    }
}