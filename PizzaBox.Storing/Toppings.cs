using System;
using System.Collections.Generic;

namespace PizzaBox.Storing
{
    public partial class Toppings
    {
        public int ToppingItem { get; set; }
        public int? PizzaId { get; set; }

        public virtual Pizza Pizza { get; set; }
    }
}
