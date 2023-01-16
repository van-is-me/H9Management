using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CusId { get; set; }
        public string CusName { get; set; }
        public string Phone { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
