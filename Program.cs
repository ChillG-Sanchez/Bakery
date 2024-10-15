using System;

namespace PeksegSimulacio
{
    class Program
    {
        static void Main(string[] args)
        {
            Bakery pekseg = new Bakery("Kóstoló Pékség");

            Croissant croissant = new Croissant("Kifli", 150, 300, 20);
            Muffin muffin = new Muffin("Muffin", 200, 350, "Csokoládé");
            Bagel bagel = new Bagel("Bagel", 180, 250, "Szezámmag");

            pekseg.AddProduct(croissant);
            pekseg.AddProduct(muffin);
            pekseg.AddProduct(bagel);

            Espresso espresso = new Espresso("Espresso", 300, 30, 80, false);
            Latte latte = new Latte("Latte", 400, 250, 100, true);
            Cappuccino cappuccino = new Cappuccino("Cappuccino", 350, 200, 90, true);

            pekseg.AddProduct(espresso);
            pekseg.AddProduct(latte);
            pekseg.AddProduct(cappuccino);

            pekseg.DisplayProducts();
            Console.WriteLine($"Összes ár: {pekseg.CalculateTotalPrice()} Ft");
            Console.WriteLine($"Összes kalória: {pekseg.CalculateTotalCalories()} kcal");

            Console.WriteLine("\nÁrak emelése...\n");

            foreach (var product in pekseg.Products)
            {
                product.IncreasePrice(50); // Példa áremelés
            }

            pekseg.DisplayProducts();
            Console.WriteLine($"Összes ár: {pekseg.CalculateTotalPrice()} Ft");
            Console.WriteLine($"Összes kalória: {pekseg.CalculateTotalCalories()} kcal");
        }
    }
}