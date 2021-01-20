using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class ThirdPartyDTO : BaseDomain
    {
        public ThirdPartyDTO()
        {
            SubCategoryThirdParties = new HashSet<SubCategoryThirdPartyDTO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? OldId { get; set; }

        public  ICollection<SubCategoryThirdPartyDTO> SubCategoryThirdParties { get; set; }
    }
}
