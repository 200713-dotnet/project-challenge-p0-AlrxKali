using System;
using System.Collections.Generic;

namespace PizzaBox.Storing
{
    public partial class Orders
    {
        public Orders()
        {
            Stores = new HashSet<Stores>();
        }

        public int OrderId { get; set; }
        public int? PizzaId { get; set; }

        public virtual Pizza Pizza { get; set; }
        public virtual ICollection<Stores> Stores { get; set; }
    }
}
