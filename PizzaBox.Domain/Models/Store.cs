using System;
using System.Collections.Generic;

namespace PizzaBox.Domain
{
    public class Store
    {
      int id ;
      int location;
      Store store;

      public List<Order> Order {get;}

      public Store()
      {
        
      }

      public Store(int location)
      {
        if (location == 1)
        {
          store = new Store();
          store.id = 1;
          Order = new List<Order>();
        }
        else
        {
          store = new Store();
          store.id = 2;
          Order = new List<Order>();
        }
      }

    }
}