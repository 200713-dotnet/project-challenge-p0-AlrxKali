using System;
using System.Collections.Generic;

namespace PizzaBox.Storing
{
    public partial class Stores
    {
        public Stores()
        {
            Users = new HashSet<Users>();
        }

        public int StoreId { get; set; }
        public int? OrderId { get; set; }
        public string StoreLocation { get; set; }

        public virtual Orders Order { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
