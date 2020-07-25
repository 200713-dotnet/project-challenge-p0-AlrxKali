using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Domain
{
  class Pizza
  {
    public string _price = "0";

    public string Crust {get; set;}
    public string Size {get; set;}

    string[] _toppings = new string[5];

    public string[] Toppings
    {
      get
      {
        return _toppings;
      }
    }

    public Pizza()
    {

    }
    
    public Pizza(string crust, string size)
    {
      Crust = crust;
      Size = size;

      Toppings[0] = "tomato sauce";
      Toppings[1] = "cheese";
    }

    public void AddToppings(String[] toppings)
    {
      for (int i = 2; i < 5; i++)
      {
        Toppings[i] = toppings[i - 2];
      }
    }
    public override string ToString()
    {
      var sb = new StringBuilder();

      foreach(var t in Toppings)
      {
        sb.Append(t + ", ");
      }
      return $"{Crust} \n{Size} \n{sb}";
    }
  }
}
