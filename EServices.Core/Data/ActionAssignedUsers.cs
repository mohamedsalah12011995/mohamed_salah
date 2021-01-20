using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class ActionAssignedUsers
    {
        public int ApplicationStageActionId { get; set; }
        public int UserId { get; set; }

        public virtual ApplicationStageActions ApplicationStageAction { get; set; }
        public virtual Users User { get; set; }
    }
}
