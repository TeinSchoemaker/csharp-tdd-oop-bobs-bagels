using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Discount
    {
        public int RequiredAmount { get; set; }
        public float DiscountPrice { get; set; }

        public Discount(int requiredAmount, float discountPrice)
        {
            RequiredAmount = requiredAmount;
            DiscountPrice = discountPrice;
        }

        public float CalculateDiscount(int amount, float  price)
        {
            int basketAmount = amount / RequiredAmount;
            int remainder = amount % RequiredAmount;

            return (basketAmount * DiscountPrice) + (remainder * price);
        }
    }
}
