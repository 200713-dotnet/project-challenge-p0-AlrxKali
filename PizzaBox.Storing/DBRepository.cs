using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Storing;
using domain = PizzaBox.Domain.Models;

namespace PizzaBox.Storing
{
  public class DBRepository
  { /*
    private PizzaBoxDBContext _db = new PizzaBoxDBContext();

    public void Create(Pizza pizza)
    {
      var newPizza = new Pizza();

      newPizza.Crust = new Crust() { Name = pizza.Crust };
      newPizza.Size = new Size() { Name = pizza.Size};
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
          Crust = new domain.Crust() { Name = item.Crust.Name },
          Size = new domain.Size() { Name = item.Size.Name },
          Toppings = new List<domain.Topping>()
        });
      };

      return domainPizzaList;
    }*/
  }
}