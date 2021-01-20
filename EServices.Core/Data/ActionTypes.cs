using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class ActionTypes
    {
        public ActionTypes()
        {
            ActionForms = new HashSet<ActionForms>();
            StageActions = new HashSet<StageActions>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ActionForms> ActionForms { get; set; }
        public virtual ICollection<StageActions> StageActions { get; set; }
    }
}
