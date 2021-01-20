using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class Roles
    {
        public Roles()
        {
            StageActionRoles = new HashSet<StageActionRoles>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<StageActionRoles> StageActionRoles { get; set; }
    }
}
