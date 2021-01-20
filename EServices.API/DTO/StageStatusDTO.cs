using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class StageStatusDTO : BaseDomain
    {
        public StageStatusDTO()
        {
            ApplicationStages = new HashSet<ApplicationStageDTO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public  ICollection<ApplicationStageDTO> ApplicationStages { get; set; }
    }
}
