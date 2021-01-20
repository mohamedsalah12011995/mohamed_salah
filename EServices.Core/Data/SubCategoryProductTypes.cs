using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class SubCategoryProductTypes
    {
        public int SubCategoryId { get; set; }
        public int ProductTypeId { get; set; }

        public virtual ProductTypes ProductType { get; set; }
        public virtual SubCategories SubCategory { get; set; }
    }
}
