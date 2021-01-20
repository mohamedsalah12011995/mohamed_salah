using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class StageStatuses
    {
        public StageStatuses()
        {
            ApplicationStages = new HashSet<ApplicationStages>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ApplicationStages> ApplicationStages { get; set; }
    }
}
