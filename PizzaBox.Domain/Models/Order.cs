using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain
{
  public class Order : PizzaTools
  {
    public int price = 0;
    public Pizza[] Pizza {get;}
    int _pizzaCounter = 0;
    public List<double> Price = new List<double>();
    


    public Order()//Pizza pizza)
    {
      Pizza = new Pizza[50];
    }

    public void CreatePizza(string crust, string size)
      {
        try
        {
          Pizza[_pizzaCounter] = new Pizza(crust, size);
        _pizzaCounter++;
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.Message);
        }
      }

    public new string Pricing(string size, int numberOfToppings)
    {
    //  Price.Add(price);

      return $"{price}";
    }
  }
}