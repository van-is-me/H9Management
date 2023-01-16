using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrId { get; set; }
        public string UserName { get; set; }
        public int CusId { get; set; }
        public DateTime? DateCheckIn { get; set; }
        public DateTime? DateCheckOut { get; set; }
        public bool? Status { get; set; }
        public int? Total { get; set; }
        public string MainEmp { get; set; }
        public string SubEmp { get; set; }
        public virtual Customer Cus { get; set; }
        public virtual User UserNameNavigation { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
