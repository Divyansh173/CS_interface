using System;
using System.Collections.Generic;

namespace API_APPS.Models
{
    public partial class SubCategory
    {
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; } = null!;
        public int CategoryId { get; set; }
    }
}
