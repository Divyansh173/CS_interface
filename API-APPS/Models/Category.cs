using System;
using System.Collections.Generic;

namespace API_APPS.Models
{
    public partial class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public decimal BasePrice { get; set; }
    }
}
