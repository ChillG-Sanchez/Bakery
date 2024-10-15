using System;

namespace PeksegSimulacio
{
    class Croissant : BakedGood
    {
        public int ButterContent { get; private set; }

        public Croissant(string name, decimal price, int calories, int butterContent)
            : base(name, price, calories)
        {
            ButterContent = butterContent;
        }

        public override string GetDescription()
        {
            return $"{Name} - Ár: {Price} Ft, Kalória: {Calories} kcal, Vaj mennyisége: {ButterContent} g";
        }

        public override void IncreasePrice(decimal amount)
        {
            Price += 50;
        }
    }
}