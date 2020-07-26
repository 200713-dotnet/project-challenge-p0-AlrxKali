using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Order : PizzaTools
  {
    public Pizza[] Pizza {get;}
    int _pizzaCounter = 0;


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

    internal override string Pricing(string size, int numberOfToppings)
    {
      int _price = 0;

      return $"{_price}";
    }

  }
}