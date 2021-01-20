using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class FieldTypeConstraintType
    {
        public int FieldConstraintTypeId { get; set; }
        public int FieldTypeId { get; set; }

        public virtual FieldConstraintTypes FieldConstraintType { get; set; }
        public virtual FieldTypes FieldType { get; set; }
    }
}
