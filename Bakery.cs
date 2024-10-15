using System;
using System.Collections.Generic;

namespace PeksegSimulacio
{
    class Bakery
    {
        public string Name { get; private set; }
        public List<Product> Products { get; private set; }

        public Bakery(string name)
        {
            Name = name;
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void DisplayProducts()
        {
            Console.WriteLine($"Pékség neve: {Name}");
            Console.WriteLine("Kínálat:");
            foreach (var product in Products)
            {
                Console.WriteLine(product.GetDescription());
            }
        }

        public decimal CalculateTotalPrice()
        {
            decimal total = 0;
            foreach (var product in Products)
            {
                total += product.Price;
            }
            return total;
        }

        public int CalculateTotalCalories()
        {
            int total = 0;
            foreach (var product in Products)
            {
                if (product is BakedGood bakedGood)
                {
                    total += bakedGood.Calories;
                }
            }
            return total;
        }
    }
}