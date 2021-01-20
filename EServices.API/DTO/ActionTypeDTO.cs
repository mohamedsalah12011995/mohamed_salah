using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class ActionTypeDTO : BaseDomain
    {
        public ActionTypeDTO()
        {
            ActionForms = new HashSet<ActionFormDTO>();
            StageActions = new HashSet<StageActionDTO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public  ICollection<ActionFormDTO> ActionForms { get; set; }
        public  ICollection<StageActionDTO> StageActions { get; set; }
    }
}
