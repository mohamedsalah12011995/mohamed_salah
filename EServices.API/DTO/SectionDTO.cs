using Eservices.API.DTO;
using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class SectionDTO 
    {
        public SectionDTO()
        {
            Categories = new HashSet<CategoryDTO>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int? OldId { get; set; }

        public  ICollection<CategoryDTO> Categories { get; set; }
    }
}
