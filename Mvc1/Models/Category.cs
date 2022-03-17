using System;
using System.Collections.Generic;

namespace Mvc1.Models
{
    public partial class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }
        public byte[]? Picture { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
