using exercise.main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.tests
{
    public class ProductTest
    {

        [Test]
        public void KnowTheCostOfBagel()
        {
            var bagel = Inventory.CreateBagel(BagelVariant.Onion);

            Assert.That(bagel.Price, Is.EqualTo(0.49f));
        }

        [Test]
        public void CanAddDifferentTypesToBasket()
        {
            var basket = new Basket(5);

            var bagel = Inventory.CreateBagel(BagelVariant.Onion);
            var filling = Inventory.CreateFilling(FillingVariant.Cheese);

            basket.AddItem(bagel);
            basket.AddItem(filling);

            Assert.Contains(bagel, basket.Products);
            Assert.Contains(filling, basket.Products);
        }
    }
}
