using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class OrderDetail
    {
        public int OrDeId { get; set; }
        public int OrId { get; set; }
        public int SerId { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }

        public virtual Order Or { get; set; }
        public virtual Service Ser { get; set; }
    }
}
