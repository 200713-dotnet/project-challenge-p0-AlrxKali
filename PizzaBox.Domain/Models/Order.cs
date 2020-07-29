using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain
{
  public class Order : PizzaTools
  {
    public Pizza[] Pizza {get;}

    int _pizzaCounter = 0;
    static double maxOrder ;
    public List<double> Price = new List<double>();

    public List<double> total = new List<double>();


    public Order()
    {
      Pizza = new Pizza[50];
    }

 
    public void CreatePizza(string crust, string size, String[] toppings)
      {
        try
        {
          if (_pizzaCounter <= 50)
          {
            Pizza[_pizzaCounter] = new Pizza(crust, size, toppings);
          _pizzaCounter++;
          }
          else
          {
            Console.WriteLine("Sorry, but you cannot order more than 50 pizzas");
          }
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.Message);
        }
      }

    public override string Pricing(string size, int numberOfToppings)
    {
     double _regular = 7.99;
      double _price;
      const double _toppingPrice = 0.5; 

      if (size.Equals("L"))
      {
        _price = _regular + 2.00 + _toppingPrice * numberOfToppings;
      }
      else if (size.Equals("F"))
      {
        _price = _regular + 3.5 + _toppingPrice * numberOfToppings;
      }
      else 
      {
        _price = _regular + _toppingPrice*numberOfToppings;
      }

      maxOrder += _price;

      return $"{_price}";
    }

    public string TotalCost()
    {
      return $"{maxOrder}";
    }
  }
}