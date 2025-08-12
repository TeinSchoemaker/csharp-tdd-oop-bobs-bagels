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

            Assert.That(total, Is.EqualTo(0.88f));
        }

        [Test]
        public void AddBagelNotInInventoryThrowsError()
        {
            var basket = new Basket(5);
            var notInInventory = (BagelVariant)20;

            var error = Assert.Throws<InvalidOperationException>(() => Inventory.CreateBagel(notInInventory));

            Assert.That(error.Message, Is.EqualTo("Bagel not in inventory"));
        }

        [Test]
        public void TotalPriceCalculatedWithSpecialDiscount()
        {
            var basket = new Basket(20);

            for (int i = 0; i < 6; i++)
            {
                basket.AddItem(Inventory.CreateBagel(BagelVariant.Onion));
            }

            for (int i = 0; i < 12; i++)
            {
                basket.AddItem(Inventory.CreateBagel(BagelVariant.Plain));
            }

            var checkout = new CheckOut();
            var total = checkout.TotalPrice(basket);
            var receipt = checkout.Receipt(basket);

            Assert.That(total, Is.EqualTo(2.49f + 3.99f));
        }
    }
}
