using exercise.main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace exercise.tests
{
    public class BasketTest
    {
        [Test]
        public void AddBagelToBasketHasCorrectBagel()
        {
            var basket = new Basket(5);
            var bagel = Inventory.CreateBagel(BagelVariant.Sesame);

            var added = basket.AddItem(bagel);

            Assert.IsTrue(added);
            Assert.Contains(bagel, basket.Products);
        }

        [Test]
        public void RemoveBagelFromBasketNoLongerHasThatBagel()
        {
            var basket = new Basket(5);
            var bagel = Inventory.CreateBagel(BagelVariant.Sesame);

            var added = basket.AddItem(bagel);
            var removed = basket.RemoveItem(bagel);

            Assert.IsTrue(removed);
            Assert.False(basket.Products.Contains(bagel));
        }

        [Test]
        public void AddBagelPastCapacityThrowsError()
        {
            var basket = new Basket(2);

            basket.AddItem(Inventory.CreateBagel(BagelVariant.Plain));
            basket.AddItem(Inventory.CreateBagel(BagelVariant.Onion));

            var added = basket.AddItem(Inventory.CreateBagel(BagelVariant.Everything));

            Assert.IsFalse(added);
        }

        [Test]
        public void RemoveNonExistantBagelThrowsError()
        {
            var basket = new Basket(5);
            var bagel = Inventory.CreateBagel(BagelVariant.Sesame);

            var removed = basket.RemoveItem(bagel);

            Assert.IsFalse(removed);
        }

        [Test]
        public void ChangeCapacityAllowsMoreItems()
        {
            var basket = new Basket(1);

            basket.AddItem(Inventory.CreateBagel(BagelVariant.Plain));
            var added = basket.AddItem(Inventory.CreateBagel(BagelVariant.Onion));
            Assert.IsFalse(added);

            basket.ChangeCapacity(2);

            added = basket.AddItem(Inventory.CreateCoffee(CoffeeVariant.Black));

            Assert.IsTrue(added);
            Assert.AreEqual(2, basket.Products.Count);
        }
    }
}
