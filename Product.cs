using System;

namespace PeksegSimulacio
{
    abstract class Product
    {
        public string Name { get; private set; }
        public decimal Price { get; protected set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public abstract string GetDescription();
        public abstract void IncreasePrice(decimal amount);
    }
}