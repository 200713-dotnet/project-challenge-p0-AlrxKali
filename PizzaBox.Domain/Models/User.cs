using System;
using System.Collections.Generic;

namespace PizzaBox.Domain
{
    public class User
    {
      public List<Order> Order {get;}

      public User()
      {
        Order = new List<Order>();
      }
    }
}