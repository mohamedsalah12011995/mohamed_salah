using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class Groups
    {
        public Groups()
        {
            InverseParent = new HashSet<Groups>();
            Services = new HashSet<Services>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public int OrderNumber { get; set; }
        public string Description { get; set; }

        public virtual Groups Parent { get; set; }
        public virtual ICollection<Groups> InverseParent { get; set; }
        public virtual ICollection<Services> Services { get; set; }
    }
}
