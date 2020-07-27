using System;

namespace PizzaBox.Domain.Abstracts
{
  public class PizzaTools
  {
    public virtual string Pricing(string size, int numberOfToppings)
    {
      double _regular = 7.99;
      double _price;
      const double _toppingPrice = 0.5; 

      if (size.Equals("L"))
      {
        _price = _regular + 2.00 + _toppingPrice * numberOfToppings;
      }
      else
      {
        _price = _regular + 3.5 + _toppingPrice * numberOfToppings;
      }
      return $"{_price}";
    }
  }
}