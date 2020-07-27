using System;
using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain
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