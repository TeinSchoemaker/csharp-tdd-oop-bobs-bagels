using System;
using NUnit.Framework;
using exercise.main;

namespace exercise.tests
{
    public class CheckOutTest
    {
        [Test]
        public void GetTotalCostIsSumOfAllPrices()
        {
            var basket = new Basket(10);
            var checkout = new CheckOut();

            basket.AddItem(Inventory.CreateBagel(BagelVariant.Plain));
            basket.AddItem(Inventory.CreateBagel(BagelVariant.Sesame));

            var total = checkout.TotalPrice(basket);

            Assert.AreEqual(0.88f, total);
        }

        [Test]
        public void AddBagelNotInInventoryThrowsError()
        {
            var basket = new Basket(5);
            var notInInventory = (BagelVariant)20;

            var error = Assert.Throws<InvalidOperationException>(() => Inventory.CreateBagel(notInInventory));

            Assert.AreEqual("Bagel not in inventory", error.Message);
        }
    }
}
