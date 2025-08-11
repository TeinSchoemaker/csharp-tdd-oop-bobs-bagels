using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace exercise.tests
{
    public class CheckoutTest
    {
        [Test]
        public void GetTotalCostIsSumOfAllPrices()
        {
            var basket = new Basket();
            var checkout = new Checkout();
            basket.AddBagel(new Bagel("Plain"));
            basket.AddBagel(new Bagel("Sesame"));

            var total = checkout.GetTotalCost();

            Assert.Equals(2.20, total);
        }

        [Test]
        public void AddBagelNotInInventoryThrowsError()
        {
            var basket = new Basket();

            var error = Assert.Throws<InvalidOperationException>(() => basket.AddBagel(new Bagel("Frozen")));

            Assert.Equals("Item not in our stock", error.Message);
        }
    }
}
