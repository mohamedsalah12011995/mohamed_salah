using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class FormSections
    {
        public FormSections()
        {
            FormSectionAttachments = new HashSet<FormSectionAttachments>();
            FormSectionFields = new HashSet<FormSectionFields>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int FormId { get; set; }
        public int OrderNumber { get; set; }
        public string Settings { get; set; }

        public virtual Forms Form { get; set; }
        public virtual ICollection<FormSectionAttachments> FormSectionAttachments { get; set; }
        public virtual ICollection<FormSectionFields> FormSectionFields { get; set; }
    }
}
