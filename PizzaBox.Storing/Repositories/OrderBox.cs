using System;
using System.Collections.Generic;
using System.Linq;
using domain = PizzaBox.Domain;

namespace PizzaBox.Storing.Repositories
{
  public class OrderBox
  {
    private PizzaBoxDBContext _db = new PizzaBoxDBContext();

    public List<domain.Order> ReadAll()
    {
      var domainOrderList = new List<domain.Order>();

      foreach(var item in _db.Pizza.ToList())
      {
        domainOrderList.Add(new domain.Order()
        {
         // Pizza = item.Crust ,
          //Size = item.Size
          
        });
      };


      return domainOrderList;
    }
  }
}
