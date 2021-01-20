using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class StageActionDTO : BaseDomain
    {
        public StageActionDTO()
        {
            ApplicationStageActions = new HashSet<ApplicationStageActionDTO>();
            StageActionRoles = new HashSet<StageActionRoleDTO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? ActionTypeId { get; set; }
        public int OrderNumber { get; set; }
        public int StageId { get; set; }

        public  ActionTypeDTO ActionType { get; set; }
       // public  StageDTO Stage { get; set; }
        public  ICollection<ApplicationStageActionDTO> ApplicationStageActions { get; set; }
        public  ICollection<StageActionRoleDTO> StageActionRoles { get; set; }
    }
}
