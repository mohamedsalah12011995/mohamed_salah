using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class EntityDTO : BaseDomain
    {
        public EntityDTO()
        {
            EntityFields = new HashSet<EntityFieldDTO>();
            EntityRelationshipsFromEntity = new HashSet<EntityRelationshipDTO>();
            EntityRelationshipsToEntity = new HashSet<EntityRelationshipDTO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public  ICollection<EntityFieldDTO> EntityFields { get; set; }
        public  ICollection<EntityRelationshipDTO> EntityRelationshipsFromEntity { get; set; }
        public  ICollection<EntityRelationshipDTO> EntityRelationshipsToEntity { get; set; }
    }
}
