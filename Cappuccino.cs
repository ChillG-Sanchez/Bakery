using System;

namespace PeksegSimulacio
{
    class Cappuccino : CoffeeMachine
    {
        public Cappuccino(string name, decimal price, int quantity, int caffeineContent, bool hasMilkOrCream)
            : base(name, price, quantity, caffeineContent, hasMilkOrCream)
        {
        }

        public override string GetDescription()
        {
            string milkOrCream = HasMilkOrCream ? "Tejjel/Tejszínhabbal" : "Nélkül";
            return $"{Name} - Ár: {Price} Ft, Mennyiség: {Quantity} ml, Koffeintartalom: {CaffeineContent} mg, {milkOrCream}";
        }

        public override void IncreasePrice(decimal amount)
        {
            Price += amount * 0.20m; // 20%-os áremelés
        }
    }
}