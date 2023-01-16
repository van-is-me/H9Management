using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Service
    {
        public Service()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int SerId { get; set; }
        public string SerName { get; set; }
        public int Price { get; set; }
        public int CateId { get; set; }

        public virtual Category Cate { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public IEnumerable<object> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
