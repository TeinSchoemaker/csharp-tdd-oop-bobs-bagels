using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{

    public enum ProductName
    {
        Bagel, Coffee, Filling
    }

    public enum BagelVariant
    {
        Onion, Plain, Everything, Sesame
    }

    public enum CoffeeVariant
    {
        Black, White, Cappucino, Latte
    }

    public enum FillingVariant
    {
        Bacon, Egg, Cheese, CreamCheese, SmokedSalmon, Ham
    }

    public class Product
    {
        public string SKU { get; set; }
        public float Price { get; set; }
        public ProductName Name { get; set; }
        public Enum Variant { get; set; }
        public Guid Id { get; set; }

        public Product(ProductName name, Enum variant, float price)
        {
            Name = name;
            Variant = variant;
            Price = price;
            SKU = CreateSKU();
            Id = Guid.NewGuid();
        }

        private string CreateSKU()
        {
            string nameCode = Name switch
            {
                ProductName.Bagel => "BGL",
                ProductName.Coffee => "COF",
                ProductName.Filling => "FIL"
            };

            return nameCode + Variant.ToString().Substring(0, 1).ToUpper();
        }

    }
}
