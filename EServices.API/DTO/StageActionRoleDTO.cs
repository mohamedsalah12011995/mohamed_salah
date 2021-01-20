using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class StageActionRoleDTO : BaseDomain
    {
        public int StageActionId { get; set; }
        public int RoleId { get; set; }

        public  RoleDTO Role { get; set; }
        public  StageActionDTO StageAction { get; set; }
    }
}
