using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class FieldTypes
    {
        public FieldTypes()
        {
            EntityFields = new HashSet<EntityFields>();
            FieldTypeConstraintType = new HashSet<FieldTypeConstraintType>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<EntityFields> EntityFields { get; set; }
        public virtual ICollection<FieldTypeConstraintType> FieldTypeConstraintType { get; set; }
    }
}
