using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class SubCategories
    {
        public SubCategories()
        {
            SubCategoryProductTypes = new HashSet<SubCategoryProductTypes>();
            SubCategoryThirdParties = new HashSet<SubCategoryThirdParties>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? OldId { get; set; }
        public int? ParentId { get; set; }

        public virtual Categories Parent { get; set; }
        public virtual ICollection<SubCategoryProductTypes> SubCategoryProductTypes { get; set; }
        public virtual ICollection<SubCategoryThirdParties> SubCategoryThirdParties { get; set; }
    }
}
