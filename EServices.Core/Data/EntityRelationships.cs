using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class EntityRelationships
    {
        public int FromEntityId { get; set; }
        public int ToEntityId { get; set; }
        public int EntityRelationshipTypeId { get; set; }
        public int EntityFieldId { get; set; }

        public virtual EntityFields EntityField { get; set; }
        public virtual EntityRelationTypes EntityRelationshipType { get; set; }
        public virtual Entities FromEntity { get; set; }
        public virtual Entities ToEntity { get; set; }
    }
}
