using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class SubCategoryThirdPartyDTO : BaseDomain
    {
        public int ThirdPartyId { get; set; }
        public int SubCategoryId { get; set; }

        public  SubCategoryDTO SubCategory { get; set; }
        public  ThirdPartyDTO ThirdParty { get; set; }
    }
}
