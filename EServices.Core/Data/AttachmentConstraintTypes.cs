using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class AttachmentConstraintTypes
    {
        public AttachmentConstraintTypes()
        {
            AttachmentConstraints = new HashSet<AttachmentConstraints>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AttachmentConstraints> AttachmentConstraints { get; set; }
    }
}
