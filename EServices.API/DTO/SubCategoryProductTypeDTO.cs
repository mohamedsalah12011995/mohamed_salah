using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class SubCategoryProductTypeDTO : BaseDomain
    {
        public int SubCategoryId { get; set; }
        public int ProductTypeId { get; set; }

        public  ProductTypeDTO ProductType { get; set; }
        public  SubCategoryDTO SubCategory { get; set; }
    }
}
