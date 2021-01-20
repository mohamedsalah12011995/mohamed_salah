using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class EntityRelationshipDTO : BaseDomain
    {
        public int FromEntityId { get; set; }
        public int ToEntityId { get; set; }
        public int EntityRelationshipTypeId { get; set; }
        public int EntityFieldId { get; set; }

        public  EntityFieldDTO EntityField { get; set; }
        public  EntityDTO FromEntity { get; set; }
        public  EntityDTO ToEntity { get; set; }
    }
}
