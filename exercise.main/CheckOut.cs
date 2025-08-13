using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class CheckOut
    {
        public float TotalPrice(Basket basket)
        {
            var groupedBySKU = basket.Products.GroupBy(p => p.SKU);

            float total = 0;

            foreach (var group in groupedBySKU)
            {
                string sku = group.Key;
                int amount = group.Count();
                float price = group.First().Price;
          
                if (Inventory.Discounts.ContainsKey(sku))
                {
                    var special = Inventory.Discounts[sku];
                    int n = special.RequiredAmount;
                    float discountPrice = special.DiscountPrice;

                    int sets = amount / n;
                    int remainder = amount % n;

                    total += (sets * discountPrice) + (remainder * price);
                }
                else
                {
                    total += amount * price;
                }


            }

            return total;
        }

        public string Receipt(Basket basket)
        {

            var receipt = new StringBuilder();
            receipt.AppendLine("\n~~~ Bob's Bagels ~~~\n");
            receipt.AppendLine(DateTime.Now.ToString() + "\n");
            receipt.AppendLine("----------------------------\n");

            var groupedBySKU = basket.Products.GroupBy(p => p.SKU);

            foreach (var group in groupedBySKU)
            {
                string sku = group.Key;
                int amount = group.Count();
                string itemName = group.First().Name.ToString();
                string variant = group.First().Variant.ToString();
                float price = group.First().Price;

                float total = 0;

                if (Inventory.Discounts.ContainsKey(sku))
                {
                    var special = Inventory.Discounts[sku];
                    total = special.CalculateDiscount(amount, price);
                }
                else
                {
                    total = amount * price;
                }

                receipt.AppendLine($"{variant} {itemName} {amount} ${total:0.00}");
            }

            receipt.AppendLine("----------------------------\n");
            receipt.AppendLine($"Total: ${TotalPrice(basket):0.00}\n");
            receipt.AppendLine("    Thank you    ");
            receipt.AppendLine("   for your order   ");

            return receipt.ToString();
        }
    }
}
