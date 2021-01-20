using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class ApplicationStages
    {
        public ApplicationStages()
        {
            ApplicationStageActions = new HashSet<ApplicationStageActions>();
            InversePreviousStage = new HashSet<ApplicationStages>();
        }

        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public int UserId { get; set; }
        public int StageId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int StageStatusId { get; set; }
        public int? PreviousStageId { get; set; }

        public virtual Applications Application { get; set; }
        public virtual ApplicationStages PreviousStage { get; set; }
        public virtual Stages Stage { get; set; }
        public virtual StageStatuses StageStatus { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<ApplicationStageActions> ApplicationStageActions { get; set; }
        public virtual ICollection<ApplicationStages> InversePreviousStage { get; set; }
    }
}
