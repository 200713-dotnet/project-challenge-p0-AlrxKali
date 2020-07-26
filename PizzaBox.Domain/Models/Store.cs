using System;
using System.Collections.Generic;

namespace PizzaStore.Domain
{
    public class Store
    {
      public List<Order> Order {get;}

      public Store()
      {
        Order = new List<Order>();
      }

    }
}