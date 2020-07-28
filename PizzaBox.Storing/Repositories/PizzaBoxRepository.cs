using System;
using System.Collections.Generic;
using System.Linq;
using domain = PizzaBox.Domain;

namespace PizzaBox.Storing.Repositories
{
  public class PizzaBoxRepository
  {
    private PizzaBoxDBContext _db = new PizzaBoxDBContext();

    public void Create(domain.Pizza pizza)
    {
      var newPizza = new Pizza();

      newPizza.Crust = pizza.Crust ;
      newPizza.Size = pizza.Size;
      var orderDate = DateTime.UtcNow;

      _db.Pizza.Add(newPizza);
      _db.SaveChanges();
    }

    public List<domain.Pizza> ReadAll()
    {
      var domainPizzaList = new List<domain.Pizza>();

      foreach(var item in _db.Pizza.ToList())
      {
        domainPizzaList.Add(new domain.Pizza()
        {
          Crust = item.Crust ,
          Size = item.Size
          
        });
      };


      return domainPizzaList;
    }
  }
}
