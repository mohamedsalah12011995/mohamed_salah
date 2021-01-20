using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class FormSectionFields
    {
        public FormSectionFields()
        {
            FormFieldConstraints = new HashSet<FormFieldConstraints>();
        }

        public int Id { get; set; }
        public int FormSectionId { get; set; }
        public int OrderNumber { get; set; }
        public int EntityFieldId { get; set; }

        public virtual EntityFields EntityField { get; set; }
        public virtual FormSections FormSection { get; set; }
        public virtual ICollection<FormFieldConstraints> FormFieldConstraints { get; set; }
    }
}
