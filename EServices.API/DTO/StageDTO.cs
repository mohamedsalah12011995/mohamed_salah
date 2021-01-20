using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class StageDTO : BaseDomain
    {
        public StageDTO()
        {
            //ApplicationStages = new HashSet<ApplicationStageDTO>();
            StageActions = new HashSet<StageActionDTO>();
            StageForms = new HashSet<StageFormDTO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int OrderNumber { get; set; }
        public int ServiceId { get; set; }

        //public  ServiceDTO Service { get; set; }
        //public  ICollection<ApplicationStageDTO> ApplicationStages { get; set; }
        public  ICollection<StageActionDTO> StageActions { get; set; }
        public  ICollection<StageFormDTO> StageForms { get; set; }
    }
}
