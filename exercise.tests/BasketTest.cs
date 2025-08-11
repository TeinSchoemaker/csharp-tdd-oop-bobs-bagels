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
            var basket = new Basket();
            var bagel = new Bagel("Sesame");

            basket.AddBagel(bagel);

            Assert.Contains(bagel, basket.Items);
        }

        [Test]
        public void RemoveBagelFromBasketNoLongerHasThatBagel()
        {
            var basket = new Basket();
            var bagel = new Bagel("Sesame");

            basket.AddBagel(bagel);
            Assert.Contains(bagel, basket);
            basket.RemoveBagel(bagel);

            Assert.DoesNotContain(bagel, basket.Items);
        }

        [Test]
        public void AddBagelPastCapacityThrowsError()
        {
            var basket = new Basket();
            basket.Capacity = 2;
            basket.AddBagel(new Bagel("Plain"));
            basket.AddBagel(new Bagel("Sesame"));

            var error = Assert.Throws<InvalidOperationException>(() => basket.AddBagel(new Bagel("Onion")));

            Assert.Equal("Basket is at capacity", error.Message);
        }

        [Test]
        public void RemoveNonExistantBagelThrowsError()
        {
            var basket = new Basket();
            var bagel = new Bagel("Sesame");

            var ex = Assert.Throws<InvalidOperationException>(() =>
                basket.RemoveBagel(bagel));

            Assert.Equal("There is no such bagel in the basket", ex.Message);
        }

        [Test]
        public void ChangeCapacity()
        {
            var basket = new Basket();
            basket.Capacity = 1;

            basket.AddBagel(new Bagel("Plain"));
            Assert.Throws<InvalidOperationException>(() => basket.AddBagel(new Bagel("Onion")));

            basket.ChangeCapacity(2);
            basket.AddBagel(new Bagel("Plain"));

            Assert.Equal(2, basket.Items.Count);
        }
    }
}
