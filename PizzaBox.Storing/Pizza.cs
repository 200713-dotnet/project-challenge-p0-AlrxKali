using System;
using System.Collections.Generic;

namespace PizzaBox.Storing
{
    public partial class Pizza
    {
        public Pizza()
        {
            Orders = new HashSet<Orders>();
            Toppings = new HashSet<Toppings>();
        }

        public int PizzaId { get; set; }
        public string Crust { get; set; }
        public string Size { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<Toppings> Toppings { get; set; }
    }
}
