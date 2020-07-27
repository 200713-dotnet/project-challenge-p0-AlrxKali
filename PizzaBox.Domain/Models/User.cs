using System;
using System.Collections.Generic;
using PizzaBox.Domain.Models;

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