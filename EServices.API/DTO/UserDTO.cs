using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class UserDTO : BaseDomain
    {
        public UserDTO()
        {
            //ActionAssignedUsers = new HashSet<ActionAssignedUserDTO>();
            //ApplicationStageActions = new HashSet<ApplicationStageActionDTO>();
            //ApplicationStages = new HashSet<ApplicationStageDTO>();
            //Applications = new HashSet<ApplicationDTO>();
        }

        public int Id { get; set; }
        public string ExternalId { get; set; }

        //public  ICollection<ActionAssignedUserDTO> ActionAssignedUsers { get; set; }
        //public  ICollection<ApplicationStageActionDTO> ApplicationStageActions { get; set; }
        //public  ICollection<ApplicationStageDTO> ApplicationStages { get; set; }
        //public  ICollection<ApplicationDTO> Applications { get; set; }
    }
}
