using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class EntityRelationTypes
    {
        public EntityRelationTypes()
        {
            EntityRelationships = new HashSet<EntityRelationships>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<EntityRelationships> EntityRelationships { get; set; }
    }
}
