
using exercise.main;

class Program
{
    static void Main(string[] args)
    {
        var bagel = Inventory.CreateBagel(BagelVariant.Onion);
        var coffee = Inventory.CreateCoffee(CoffeeVariant.Cappucino);
        var filling = Inventory.CreateFilling(FillingVariant.Cheese);
        var basket = new Basket(5);

        basket.AddItem(bagel);
        basket.AddItem(coffee);
        basket.AddItem(filling);

        var checkout = new CheckOut();
        Console.WriteLine(checkout.Receipt(basket));
    }
}