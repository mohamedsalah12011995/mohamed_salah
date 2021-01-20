using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class ProductTypes
    {
        public ProductTypes()
        {
            SubCategoryProductTypes = new HashSet<SubCategoryProductTypes>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? OldId { get; set; }

        public virtual ICollection<SubCategoryProductTypes> SubCategoryProductTypes { get; set; }
    }
}
