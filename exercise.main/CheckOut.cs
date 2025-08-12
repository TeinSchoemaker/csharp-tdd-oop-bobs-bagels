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
            float total = basket.Products.Sum(p => p.Price);

            return total;
        }

        public string Receipt(Basket basket)
        {
            var receipt = new StringBuilder();
            receipt.AppendLine("~~~ Bob's Bagels ~~~\n");
            receipt.AppendLine(DateTime.Now.ToString() + "\n");
            receipt.AppendLine("----------------------------\n");
            foreach (var product in basket.Products)
            {
                receipt.AppendLine($"{product.Name} ({product.Variant}): ${product.Price}");
            }
            receipt.AppendLine("----------------------------\n");
            receipt.AppendLine($"Total: ${TotalPrice(basket):0.00}\n");
            receipt.AppendLine("    Thank you    ");
            receipt.AppendLine("   for your order   ");
            return receipt.ToString();
        }

        public void CashOrCard(float total)
        {

        }
    }
}
