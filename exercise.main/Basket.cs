using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Basket
    {
        public List<Product> Products { get; set; }
        public int Capacity { get; set; }

        public Basket(int capacity)
        {
            Capacity = capacity;
            Products = new List<Product>();
        }

        public bool AddItem(Product product)
        {
            if (Products.Count >= Capacity)
            {
                return false;
            }

            Products.Add(product);
            return true;
        }

        public bool RemoveItem(Product product)
        {      
            var selectedItem =  Products.FirstOrDefault(p => p.Id == product.Id);
            if (selectedItem == null)
            {
                return false;
            }

            Products.Remove(selectedItem);
            return true;
        }

        public void ChangeCapacity(int capacity)
        {
            Capacity = capacity;
        }
    }
}
