using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class SubCategoryDTO : BaseDomain
    {
        public SubCategoryDTO()
        {
            SubCategoryProductTypes = new HashSet<SubCategoryProductTypeDTO>();
            SubCategoryThirdParties = new HashSet<SubCategoryThirdPartyDTO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? OldId { get; set; }
        public int? ParentId { get; set; }

        public  CategoryDTO Parent { get; set; }
        public  ICollection<SubCategoryProductTypeDTO> SubCategoryProductTypes { get; set; }
        public  ICollection<SubCategoryThirdPartyDTO> SubCategoryThirdParties { get; set; }
    }
}
