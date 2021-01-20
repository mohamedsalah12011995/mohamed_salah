using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class ApplicationStageActionDTO : BaseDomain
    {
        public ApplicationStageActionDTO()
        {
            ActionAssignedUsers = new HashSet<ActionAssignedUserDTO>();
        }

        public int Id { get; set; }
        public int ApplicationStageId { get; set; }
        public int StageActionId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UserId { get; set; }
        public string Data { get; set; }

        public  ApplicationStageDTO ApplicationStage { get; set; }
        public  StageActionDTO StageAction { get; set; }
        //public  UserDTO User { get; set; }
        public  ICollection<ActionAssignedUserDTO> ActionAssignedUsers { get; set; }
    }
}
