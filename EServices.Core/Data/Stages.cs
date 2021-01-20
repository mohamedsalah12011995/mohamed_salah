using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class Stages
    {
        public Stages()
        {
            ApplicationStages = new HashSet<ApplicationStages>();
            StageActions = new HashSet<StageActions>();
            StageForms = new HashSet<StageForms>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int OrderNumber { get; set; }
        public int ServiceId { get; set; }

        public virtual Services Service { get; set; }
        public virtual ICollection<ApplicationStages> ApplicationStages { get; set; }
        public virtual ICollection<StageActions> StageActions { get; set; }
        public virtual ICollection<StageForms> StageForms { get; set; }
    }
}
