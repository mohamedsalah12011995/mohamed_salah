using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class Users
    {
        public Users()
        {
            ActionAssignedUsers = new HashSet<ActionAssignedUsers>();
            ApplicationStageActions = new HashSet<ApplicationStageActions>();
            ApplicationStages = new HashSet<ApplicationStages>();
            Applications = new HashSet<Applications>();
        }

        public int Id { get; set; }
        public string ExternalId { get; set; }

        public virtual ICollection<ActionAssignedUsers> ActionAssignedUsers { get; set; }
        public virtual ICollection<ApplicationStageActions> ApplicationStageActions { get; set; }
        public virtual ICollection<ApplicationStages> ApplicationStages { get; set; }
        public virtual ICollection<Applications> Applications { get; set; }
    }
}
