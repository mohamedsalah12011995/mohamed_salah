using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class GroupDTO : BaseDomain
    {
        public GroupDTO()
        {
            InverseParent = new HashSet<GroupDTO>();
            Services = new HashSet<ServiceDTO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public int OrderNumber { get; set; }
        public string Description { get; set; }

        public  GroupDTO Parent { get; set; }
        public  ICollection<GroupDTO> InverseParent { get; set; }
        public  ICollection<ServiceDTO> Services { get; set; }
    }
}
