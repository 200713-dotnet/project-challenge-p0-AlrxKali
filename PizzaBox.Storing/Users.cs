using System;
using System.Collections.Generic;

namespace PizzaBox.Storing
{
    public partial class Users
    {
        public int UsersId { get; set; }
        public int? StoresId { get; set; }
        public byte[] LastOrderTime { get; set; }

        public virtual Stores Stores { get; set; }
    }
}
