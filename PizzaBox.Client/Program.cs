using System;
using System.Collections.Generic;
using PizzaBox.Client;
using PizzaBox.Domain;

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
        System.Console.WriteLine("Welcome to PizzaWorld");
        System.Console.WriteLine("Best Pizza in the World");
        System.Console.WriteLine();

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
      var exit = false;

      do
      {
        Starter.PrintMenu();

        int select;

        int.TryParse(Console.ReadLine(), out select);

        switch (select)
        {
          case 1:
            cart.CreatePizza("L", "Stuffed");
            System.Console.WriteLine("added Cheese");
            break;
          case 2:
            cart.CreatePizza("L", "Stuffed");
            System.Console.WriteLine("added Pepperoni");
            break;
          case 3:
            cart.CreatePizza("L", "Stuffed");
            System.Console.WriteLine("added Pineapple");
            break;
          case 4:
            cart.CreatePizza("L", "Stuffed");
            System.Console.WriteLine("added Custom");
            break;
          case 5:
            DisplayCart(cart);
            break;
          case 6:
            //var fmw = new FileManager();
            //fmw.Write(cart);
            System.Console.WriteLine("thank you, goodbye!");
            exit = true;
            break;
          case 7:
            //var fmr = new FileManager();
            //DisplayCart(fmr.Read());
            break;
        }

        System.Console.WriteLine();
      } while (!exit);
    }

    static void DisplayCart(Order cart)
      {
        foreach (var pizza in cart.Pizza)
       {
         Console.WriteLine(pizza);
         Console.WriteLine(cart.Pricing(pizza.Size, pizza.Toppings.Length));
       }
      
     }
    }
}