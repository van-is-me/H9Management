using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Category
    {
        public Category()
        {
            Services = new HashSet<Service>();
        }

        public int CateId { get; set; }
        public string CateName { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}
