using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class AttachmentTypes
    {
        public AttachmentTypes()
        {
            FormSectionAttachments = new HashSet<FormSectionAttachments>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<FormSectionAttachments> FormSectionAttachments { get; set; }
    }
}
