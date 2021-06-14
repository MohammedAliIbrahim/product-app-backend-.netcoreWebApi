using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication36.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductTags = new HashSet<ProductTag>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CatId { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsArchived { get; set; }

        public virtual Category Cat { get; set; }
        public virtual ICollection<ProductTag> ProductTags { get; set; }
    }
}
