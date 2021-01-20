using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class ActionAssignedUserDTO : BaseDomain
    {
        public int ApplicationStageActionId { get; set; }
        public int UserId { get; set; }

        public  ApplicationStageActionDTO ApplicationStageAction { get; set; }
        public  UserDTO User { get; set; }
    }
}
