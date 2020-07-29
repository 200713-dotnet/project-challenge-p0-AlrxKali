using System;
using PizzaBox.Domain;
using System.Collections.Generic;

namespace PizzaBox.Storing
{
  interface PizzaBoxInterfaces
  {
    List<Order> OrderHistory { get; }

  OrderHistory OrderById(int id);
  
    int EditOrder(OrderHistory edit);
    int AddCar(OrderHistory add);
        
    int DeleteOrder(int id);
       
  }

  public class OrderHistory
  {
  }
}
