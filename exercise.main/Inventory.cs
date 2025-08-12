using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public static class Inventory
    {
        public static Dictionary<BagelVariant, float> Bagels = new Dictionary<BagelVariant, float>()
        {
            { BagelVariant.Onion, 0.49f },
            { BagelVariant.Plain, 0.39f },
            { BagelVariant.Everything, 0.49f },
            { BagelVariant.Sesame, 0.49f }
        };

        public static Dictionary<CoffeeVariant, float> Coffees = new Dictionary<CoffeeVariant, float>()
        {
            { CoffeeVariant.Black, 0.99f },
            { CoffeeVariant.White, 1.19f },
            { CoffeeVariant.Cappucino, 1.29f },
            { CoffeeVariant.Latte, 1.29f }
        };

        public static Dictionary<FillingVariant, float> Fillings = new Dictionary<FillingVariant, float>()
        {
            { FillingVariant.Bacon, 0.12f },
            { FillingVariant.Egg, 0.12f },
            { FillingVariant.Cheese, 0.12f },
            { FillingVariant.CreamCheese, 0.12f },
            { FillingVariant.SmokedSalmon, 0.12f },
            { FillingVariant.Ham, 0.12f }
        };

        public static Dictionary<string, Discount> Discounts = new Dictionary<string, Discount>()
        {
            { "BGLO", new Discount(6, 2.49f) },
            { "BGLP", new Discount(12, 3.99f) },
            { "BGLE", new Discount(6, 2.49f) }
        };

        public static Product CreateBagel(BagelVariant variant)
        {
            if (!Bagels.ContainsKey(variant))
            {
                throw new InvalidOperationException("Bagel not in inventory");
            }

            return new Product(ProductName.Bagel, variant, Bagels[variant]);
        }

        public static Product CreateCoffee(CoffeeVariant variant)
        {
            if (!Coffees.ContainsKey(variant))
            {
                throw new InvalidOperationException("Coffee not in inventory");
            }

            return new Product(ProductName.Coffee, variant, Coffees[variant]);
        }

        public static Product CreateFilling(FillingVariant variant)
        {
            if (!Fillings.ContainsKey(variant))
            {
                throw new InvalidOperationException("Filling not in inventory");
            }

            return new Product(ProductName.Filling, variant, Fillings[variant]);
        }
    }
}