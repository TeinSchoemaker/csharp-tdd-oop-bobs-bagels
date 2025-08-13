
using exercise.main;
using Twilio.TwiML.Voice;

class Program
{
    static void Main(string[] args)
    {
        var basket = new Basket(5);

        Console.WriteLine("Welcome To Bob's Burgers!\n");

        while (true)
        {
            Console.WriteLine("What would you like: \n");
            Console.WriteLine("1. Add bagel to basket");
            Console.WriteLine("2. Add coffee to basket");
            Console.WriteLine("3. Remove bagel from basket");
            Console.WriteLine("4. Change basket capacity");
            Console.WriteLine("5. Show total cost");
            Console.WriteLine("6. Checkout basket");
            Console.WriteLine("7. Leave emptyhanded\n");

            var checkout = new CheckOut();
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("\nWhat bagel do you want?\n");
                    Console.WriteLine("1. Onion");
                    Console.WriteLine("2. Plain");
                    Console.WriteLine("3. Everything");
                    Console.WriteLine("4. Sesame\n");
                    var bagelInput = Console.ReadLine();
                    switch (bagelInput)
                    {
                        case "1":
                            basket.AddItem(Inventory.CreateBagel(BagelVariant.Onion));
                            Console.WriteLine("\nOnion bagel added!\n");
                            break;

                        case "2":
                            basket.AddItem(Inventory.CreateBagel(BagelVariant.Plain));
                            Console.WriteLine("\nPlain bagel added!\n");
                            break;

                        case "3":
                            basket.AddItem(Inventory.CreateBagel(BagelVariant.Everything));
                            Console.WriteLine("\nEverything bagel added!\n");
                            break;

                        case "4":
                            basket.AddItem(Inventory.CreateBagel(BagelVariant.Sesame));
                            Console.WriteLine("\nSesame bagel added!\n");
                            break;
                    }
                    Console.WriteLine("Would you like a filling with that? Y/N\n");
                    var wouldYouInput = Console.ReadLine();
                    switch (wouldYouInput.ToLower())
                    {
                        case "y":
                            Console.WriteLine("\nWhat filling do you want?\n");
                            Console.WriteLine("1. Bacon");
                            Console.WriteLine("2. Egg");
                            Console.WriteLine("3. Cheese");
                            Console.WriteLine("4. Cream Cheese");
                            Console.WriteLine("5. Smoked Salmon");
                            Console.WriteLine("6. Ham\n");
                            var fillingInput = Console.ReadLine();
                            switch (fillingInput)
                            {
                                case "1":
                                    basket.AddItem(Inventory.CreateFilling(FillingVariant.Bacon));
                                    Console.WriteLine("\nBacon added!\n");
                                    break;

                                case "2":
                                    basket.AddItem(Inventory.CreateFilling(FillingVariant.Egg));
                                    Console.WriteLine("\nEgg added!\n");
                                    break;

                                case "3":
                                    basket.AddItem(Inventory.CreateFilling(FillingVariant.Cheese));
                                    Console.WriteLine("\nCheese added!\n");
                                    break;

                                case "4":
                                    basket.AddItem(Inventory.CreateFilling(FillingVariant.CreamCheese));
                                    Console.WriteLine("\nCream Cheese added!\n");
                                    break;

                                case "5":
                                    basket.AddItem(Inventory.CreateFilling(FillingVariant.SmokedSalmon));
                                    Console.WriteLine("\nSmoked Salmon added!\n");
                                    break;

                                case "6":
                                    basket.AddItem(Inventory.CreateFilling(FillingVariant.Ham));
                                    Console.WriteLine("\nHam added!\n");
                                    break;
                            }
                            break;

                        case "n":
                            break;

                        default:
                            Console.WriteLine("Invalid input");
                            break;
                    }
                    break;

                case "2":
                    Console.WriteLine("\nWhat coffee do you want?\n");
                    Console.WriteLine("1. Black");
                    Console.WriteLine("2. White");
                    Console.WriteLine("3. Cappucino");
                    Console.WriteLine("4. Latte\n");
                    var coffeeInput = Console.ReadLine();
                    switch (coffeeInput)
                    {
                        case "1":
                            basket.AddItem(Inventory.CreateCoffee(CoffeeVariant.Black));
                            Console.WriteLine("\nBlack coffee added!\n");
                            break;

                        case "2":
                            basket.AddItem(Inventory.CreateCoffee(CoffeeVariant.White));
                            Console.WriteLine("\nWhite coffee added!\n");
                            break;

                        case "3":
                            basket.AddItem(Inventory.CreateCoffee(CoffeeVariant.Cappucino));
                            Console.WriteLine("\nCappucino added!\n");
                            break;

                        case "4":
                            basket.AddItem(Inventory.CreateCoffee(CoffeeVariant.Latte));
                            Console.WriteLine("\nLatte added!\n");
                            break;
                    }
                    break;

                case "3":
                    Console.WriteLine("Removing bagel UNFINISHED");
                    //basket.RemoveItem();
                    break;

                case "4":
                    Console.WriteLine("What should the new capacity be?\n");
                    var newCapacity = int.Parse(Console.ReadLine());
                    basket.ChangeCapacity(newCapacity);
                    Console.WriteLine($"The new capacity is:{newCapacity}\n");
                    break;

                case "5":
                    Console.WriteLine("The current total cost is: ");
                    Console.WriteLine(checkout.TotalPrice(basket) + "\n");
                    break;

                case "6":

                    Console.WriteLine(checkout.Receipt(basket));
                    Environment.Exit(0);
                    break;

                case "7":
                    Environment.Exit(0);
                    break;

                case "exit":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("\nInvalid input\n");
                    break;

            }
        }
    }
}