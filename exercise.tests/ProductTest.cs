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
        public void KnowTheCostOfBagelBeforeAdding()
        {
            var bagel = new Bagel("Plain");

            Assert.Equals(1.00, bagel.Price);
        }

        [Test]
        public void KnowTheCostOfFillingBeforeAdding()
        {
            var bagel = new Bagel("Plain");
            var filling = new Filling("Cream Cheese");

            bagel.AddFilling(filling);

            Assert.Contains(filling, bagel.Fillings);
        }

        [Test]
        public void AddFillingToBagelAddsRightFillingToBagel()
        {
            var filling = new Filling("Bacon");

            Assert.Equals(0.80, filling.Price);
        }
    }
}
