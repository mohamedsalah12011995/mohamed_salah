using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class StageActions
    {
        public StageActions()
        {
            ApplicationStageActions = new HashSet<ApplicationStageActions>();
            StageActionRoles = new HashSet<StageActionRoles>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? ActionTypeId { get; set; }
        public int OrderNumber { get; set; }
        public int StageId { get; set; }

        public virtual ActionTypes ActionType { get; set; }
        public virtual Stages Stage { get; set; }
        public virtual ICollection<ApplicationStageActions> ApplicationStageActions { get; set; }
        public virtual ICollection<StageActionRoles> StageActionRoles { get; set; }
    }
}
