using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class FormFieldConstraints
    {
        public int Id { get; set; }
        public int FormSectionFieldId { get; set; }
        public int? FieldConstraintTypeId { get; set; }
        public string Settings { get; set; }

        public virtual FieldConstraintTypes FieldConstraintType { get; set; }
        public virtual FormSectionFields FormSectionField { get; set; }
    }
}
