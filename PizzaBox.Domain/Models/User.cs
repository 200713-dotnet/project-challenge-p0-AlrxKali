using System;
using System.Collections.Generic;

namespace PizzaStore.Domain
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