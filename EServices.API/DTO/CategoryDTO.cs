using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class CategoryDTO : BaseDomain
    {
        public CategoryDTO()
        {
            CategoryNotifyBodies = new HashSet<CategoryNotifyBodyDTO>();
            SubCategories = new HashSet<SubCategoryDTO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? OldId { get; set; }
        public int SectionId { get; set; }
        
        public SectionDTO Section { get; set; }
        public  ICollection<CategoryNotifyBodyDTO> CategoryNotifyBodies { get; set; }
        public  ICollection<SubCategoryDTO> SubCategories { get; set; }
    }
}
