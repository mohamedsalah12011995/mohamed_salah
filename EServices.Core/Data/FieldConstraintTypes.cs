using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class FieldConstraintTypes
    {
        public FieldConstraintTypes()
        {
            FieldTypeConstraintType = new HashSet<FieldTypeConstraintType>();
            FormFieldConstraints = new HashSet<FormFieldConstraints>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<FieldTypeConstraintType> FieldTypeConstraintType { get; set; }
        public virtual ICollection<FormFieldConstraints> FormFieldConstraints { get; set; }
    }
}
