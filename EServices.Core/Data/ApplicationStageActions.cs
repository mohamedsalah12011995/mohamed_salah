using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class ApplicationStageActions
    {
        public ApplicationStageActions()
        {
            ActionAssignedUsers = new HashSet<ActionAssignedUsers>();
        }

        public int Id { get; set; }
        public int ApplicationStageId { get; set; }
        public int StageActionId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UserId { get; set; }
        public string Data { get; set; }

        public virtual ApplicationStages ApplicationStage { get; set; }
        public virtual StageActions StageAction { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<ActionAssignedUsers> ActionAssignedUsers { get; set; }
    }
}
