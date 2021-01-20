using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class EntityFields
    {
        public EntityFields()
        {
            EntityRelationships = new HashSet<EntityRelationships>();
            FormSectionFields = new HashSet<FormSectionFields>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int FieldTypeId { get; set; }
        public int EntityId { get; set; }
        public string Settings { get; set; }

        public virtual Entities Entity { get; set; }
        public virtual FieldTypes FieldType { get; set; }
        public virtual ICollection<EntityRelationships> EntityRelationships { get; set; }
        public virtual ICollection<FormSectionFields> FormSectionFields { get; set; }
    }
}
