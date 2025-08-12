
using exercise.main;

class Program
{
    static void Main(string[] args)
    {
        var bagel = new Product(ProductName.Bagel, BagelVariant.Onion, 0.49f);
        var coffee = new Product(ProductName.Coffee, CoffeeVariant.Cappucino, 1.29f);
        var filling = new Product(ProductName.Filling, FillingVariant.Egg, 0.12f);

        var basket = new Basket(5);
        basket.AddItem(bagel);
        basket.AddItem(coffee);
        basket.AddItem(filling);

        var checkout = new CheckOut();
        Console.WriteLine(checkout.Receipt(basket));
    }
}