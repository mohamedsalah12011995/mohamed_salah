using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class SubCategoryThirdParties
    {
        public int ThirdPartyId { get; set; }
        public int SubCategoryId { get; set; }

        public virtual SubCategories SubCategory { get; set; }
        public virtual ThirdParties ThirdParty { get; set; }
    }
}
