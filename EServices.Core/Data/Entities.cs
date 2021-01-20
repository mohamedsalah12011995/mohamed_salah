using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class Entities
    {
        public Entities()
        {
            EntityFields = new HashSet<EntityFields>();
            EntityRelationshipsFromEntity = new HashSet<EntityRelationships>();
            EntityRelationshipsToEntity = new HashSet<EntityRelationships>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<EntityFields> EntityFields { get; set; }
        public virtual ICollection<EntityRelationships> EntityRelationshipsFromEntity { get; set; }
        public virtual ICollection<EntityRelationships> EntityRelationshipsToEntity { get; set; }
    }
}
