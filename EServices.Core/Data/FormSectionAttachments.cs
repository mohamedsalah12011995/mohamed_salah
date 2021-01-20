using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class FormSectionAttachments
    {
        public FormSectionAttachments()
        {
            AttachmentConstraints = new HashSet<AttachmentConstraints>();
        }

        public int Id { get; set; }
        public int AttachmentTypeId { get; set; }
        public string Name { get; set; }
        public int FormSectionId { get; set; }
        public string Description { get; set; }
        public int OrderNumber { get; set; }

        public virtual AttachmentTypes AttachmentType { get; set; }
        public virtual FormSections FormSection { get; set; }
        public virtual ICollection<AttachmentConstraints> AttachmentConstraints { get; set; }
    }
}
