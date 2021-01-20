using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class ProductTypeDTO : BaseDomain
    {
        public ProductTypeDTO()
        {
            SubCategoryProductTypes = new HashSet<SubCategoryProductTypeDTO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? OldId { get; set; }

        public  ICollection<SubCategoryProductTypeDTO> SubCategoryProductTypes { get; set; }
    }
}
