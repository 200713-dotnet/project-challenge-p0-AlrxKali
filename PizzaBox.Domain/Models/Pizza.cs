using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Domain
{
  public class Pizza
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

    public void AddToppings()
    {
      var adding = true;
      Console.WriteLine("Would you like to add any extra toppings");

      var userInput = Console.ReadLine();

      if (userInput.Equals("Y"))
      {
        while(adding == true)
        {
           try
           {
             Console.WriteLine("add new topping or enter to exit");
             var newTopping = Console.ReadLine();
             if (String.IsNullOrEmpty(newTopping))
             {
               for (int i = 0; i < 5; i++)
               {
                 if (Toppings[i] == null)
                 {
                   Toppings[i] = newTopping;
                       break;
                 }else
                 {
                   i++;
                 }
               }
             }else
             {
               break;
             }
           }catch
           {
             Console.WriteLine("Sorry, you cannot add more toppings");
           }
        }
      }else
      {
        Console.WriteLine("Thank you.");
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
