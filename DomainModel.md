# Core Requirements

| Classes     | Methods/Properties                                     | Scenario                                | Outputs                           
| ----------- | ------------------------------------------------------ | --------------------------------------- | --------------------------------- 
| Product.cs  | string SKU                                             | Short code for name + variant           | String with SKU code                         
| Product.cs  | float Price                                            | Pricing for each item			         | float with price in decimal					 
| Product.cs  | enum Name                                              | Product type for each item to get       | Bagel, Coffee, Filling              				 
| Product.cs  | enum BagelVariant                                      | Types of variant you can get with bagel | Onion, Plain, Everything, Sesame                   
| Product.cs  | enum CoffeeVariant                                     | Types of variant you can get with Coffee| Black, White, Cappucino, Latte                   
| Product.cs  | enum FillingVariant                                    | Types of variant you can get for Filling| Bacon, Egg, Cheese, CreamCheese, SmokedSalmon, Ham                   
| Basket.cs   | List<\ProductList\> Basket							   | List to add each chosen item to         | Task added to list                
| Basket.cs   | Guid id												   | Id to keep track of items in basket     | Id for each item                
| Basket.cs   | bool IsFull                                            | Bool to check to see if basket is full  | True or False
| Basket.cs   | int Capacity										   | Int to decide max amount of items       | Int that dictates max items            
| Basket.cs   | AddItem(Product prodcut)                               | Add item to the basket list             | Product added to list            
| Basket.cs   | RemoveItem(Guid itemId)                                | Remove specific item from basket        | Specific item removed from list         
| Basket.cs   | ChangeCapacity(int Capacity)                           | Changes the total capacity of the basket| A changed version of the Capacity               
| Checkout.cs | int TotalPrice                                         | Int tracking the total price all items  | Int in $$$         
| Checkout.cs | string Receipt                                         | Clear version of all total costs written| Each item and it's costs written in console         
| Checkout.cs | int Discount                                           | Discount if enough items are bought     | New price calculated with new discount         
| Checkout.cs | string OrderConfirmation                               | Using twilio to print a conformation    | SMS with order conformation         
| Checkout.cs | CashOrCard()										   | Delivers the user their total		     | A console log with an overview of the transactions         