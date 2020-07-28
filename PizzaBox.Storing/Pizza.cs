using System;
using System.Collections.Generic;

namespace PizzaBox.Storing
{
    public partial class Pizza
    {
        public Pizza()
        {
            Orders = new HashSet<Orders>();
        }

        public int PizzaId { get; set; }
        public string Crust { get; set; }
        public string Size { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
