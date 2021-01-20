using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class ThirdParties
    {
        public ThirdParties()
        {
            SubCategoryThirdParties = new HashSet<SubCategoryThirdParties>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? OldId { get; set; }

        public virtual ICollection<SubCategoryThirdParties> SubCategoryThirdParties { get; set; }
    }
}
