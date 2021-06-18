﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DependenciesInjectionExample.Models
{
    public partial class Product
    {
        public Product()
        {
            Storages = new HashSet<Storage>();
        }

        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int TotalQuantity { get; set; }
        public string CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Storage> Storages { get; set; }
    }
}
