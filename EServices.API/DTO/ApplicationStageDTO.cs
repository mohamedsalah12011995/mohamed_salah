using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class ApplicationStageDTO : BaseDomain
    {
        public ApplicationStageDTO()
        {
            ApplicationStageActions = new HashSet<ApplicationStageActionDTO>();
            InversePreviousStage = new HashSet<ApplicationStageDTO>();
        }

        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public int UserId { get; set; }
        public int StageId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int StageStatusId { get; set; }
        public int? PreviousStageId { get; set; }

        public  ApplicationDTO Application { get; set; }
        public  ApplicationStageDTO PreviousStage { get; set; }
        public  StageDTO Stage { get; set; }
        public  StageStatusDTO StageStatus { get; set; }
        public  UserDTO User { get; set; }
        public  ICollection<ApplicationStageActionDTO> ApplicationStageActions { get; set; }
        public  ICollection<ApplicationStageDTO> InversePreviousStage { get; set; }
    }
}
