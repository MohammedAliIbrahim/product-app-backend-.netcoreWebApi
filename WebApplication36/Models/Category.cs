using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication36.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
            Tags = new HashSet<Tag>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
