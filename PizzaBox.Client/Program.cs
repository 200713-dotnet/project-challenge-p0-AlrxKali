using System;
using System.Collections.Generic;
using PizzaBox.Client;
using PizzaBox.Domain;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client
{
    class Program
    {
        static void Main(string[] args)
        {
        Welcome();
      }

      public static void Welcome()
      {
        Console.WriteLine("Welcome to PizzaBox");
        Console.WriteLine("How to order:");
        Console.WriteLine("First you need to select the location you want to order");
        Console.WriteLine("Select the pizzas you want or customize");
        Console.WriteLine("Each pizza has two toppings, and it cost $7.99");
        Console.WriteLine("Each addisional toppings adds 0.5 to your cost");
        Console.WriteLine("If you wish a larger size, you can pick Large for an additional cost of  $2.00");
        Console.WriteLine("You can order the family size for an additional cost of  $3.5");

       var starter = new Starter();
       var user = new User();       

       var location = Starter.PickLocation();
       var store = new Store(location);

        try 
        {
          Menu(starter.CreateOrder(user, store));
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.Message);
        }
      }
      static void Menu(Order cart)
    {
      var pizza = new Pizza();
      var exit = false;

      do
      {
        Starter.PrintMenu();

        int select;

        int.TryParse(Console.ReadLine(), out select);

        switch (select)
        {
         case 1:
            cart.CreatePizza("L", "Stuffed", new string[] {"cheese"} );
            System.Console.WriteLine("added Cheese");
            Console.WriteLine(cart.TotalCost());
            break;
          case 2:
            cart.CreatePizza("L", "Stuffed", new string[] {"pepperoni"});
            System.Console.WriteLine("added Pepperoni");
            Console.WriteLine(cart.TotalCost());
            break;
          case 3:
            cart.CreatePizza("L", "Stuffed", new string[] {"pineapple"});
            System.Console.WriteLine("added Pineapple");
            Console.WriteLine(cart.TotalCost());
            break;
          case 4:
            var userCrust = Starter.SelectCrust();
            var userSize = Starter.SelectSize();
            string[] topps = Starter.SelectToppings();
            cart.CreatePizza(userSize, userCrust, topps);
            System.Console.WriteLine("added Custom");
            break;
          case 5:
            DisplayCart(cart);
            break;
          case 6:
            //var db = new OrderBox();
            //AddOrder(cart);
            cart.TotalCost();
            System.Console.WriteLine("thank you, goodbye!");
            exit = true;
            break;
          case 7:
            //var db = new OrderBox();
            //DisplayCart(db.Read());
            break;
        }

        System.Console.WriteLine();
      } while (!exit);
    }

    static void DisplayCart(Order cart)
      {
        foreach (var pizza in cart.Pizza)
       {
         Console.WriteLine();
         Console.WriteLine(pizza);
         Console.WriteLine(cart.Pricing(pizza.Size, pizza.Toppings.Length));
         Console.WriteLine();
       }

     }
    }
}