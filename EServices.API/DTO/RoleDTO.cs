using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class RoleDTO : BaseDomain
    {
        public RoleDTO()
        {
            StageActionRoles = new HashSet<StageActionRoleDTO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public  ICollection<StageActionRoleDTO> StageActionRoles { get; set; }
    }
}
