using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Role { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
