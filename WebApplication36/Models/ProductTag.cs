﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication36.Models
{
    public partial class ProductTag
    {
        public int ProductId { get; set; }
        public int TagId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
