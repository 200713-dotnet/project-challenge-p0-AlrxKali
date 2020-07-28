using System;
using System.Collections.Generic;
using PizzaBox.Domain;

namespace PizzaBox.Client
{
  public class Starter
  {
public Order CreateOrder(User user, Store store)
    {
      try
      {
        var order = new Order();

       user.Order.Add(order);
       store.Order.Add(order);

        return order;
      }
      catch
      {
        throw new System.Exception("run again the script");
      }
      finally
      {
        GC.Collect();
      }
    }
      internal static void PrintMenu()
      {
        System.Console.WriteLine("Select 1 for Cheese Pizza ");
        System.Console.WriteLine("Select 2 for Pepperoni Pizza");
        System.Console.WriteLine("Select 3 for Pineapple Pizza");
        System.Console.WriteLine("Select 4 for Custom Pizza");
        System.Console.WriteLine("Select 5 for Show Cart");
        System.Console.WriteLine("Select 6 for Exit");
        System.Console.WriteLine();
      }

      public static int PickLocation()
      {
        int location;

        Console.WriteLine("Please, select where do you want to order");
        Console.WriteLine("1. Location 1");
        Console.WriteLine("2. Location 2");
        Console.WriteLine();

         int.TryParse(Console.ReadLine(), out location);

        return location;
      }

     public static string SelectCrust()
    {
      string crust = "Stuffed";
       int select;

        Console.WriteLine("Please, select the crust do you want for this order");
        Console.WriteLine("1. Neapolitan");
        Console.WriteLine("2. New York Style");
        Console.WriteLine("3. Stuffed");
        Console.WriteLine();

        int.TryParse(Console.ReadLine(), out select);

        

        switch (select)
        {
          case 1:
           crust = "Neapolitan";
            break;
          case 2:
            crust = "New York Style";
            break;
          default:
            return crust;
        }
        return crust;
      }

       public static string SelectSize()
    {
      Console.WriteLine("Please, select the size do you want for order");
      Console.WriteLine("1. Large");
      Console.WriteLine("2. Family");
      Console.WriteLine("3. Regular");
      Console.WriteLine();

      string size = "N";
       int select;

        int.TryParse(Console.ReadLine(), out select);

        switch (select)
        {
          case 1:
           size = "L";
            break;
          case 2:
            size = "F";
            break;
          default:
            return size;
        }
        return size;
      }
  }
}