using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class StageActionRoles
    {
        public int StageActionId { get; set; }
        public int RoleId { get; set; }

        public virtual Roles Role { get; set; }
        public virtual StageActions StageAction { get; set; }
    }
}
