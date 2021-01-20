using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class AttachmentConstraints
    {
        public int FormSectionAttachmentId { get; set; }
        public int AttachmentConstraintTypeId { get; set; }
        public string Settings { get; set; }

        public virtual AttachmentConstraintTypes AttachmentConstraintType { get; set; }
        public virtual FormSectionAttachments FormSectionAttachment { get; set; }
    }
}
