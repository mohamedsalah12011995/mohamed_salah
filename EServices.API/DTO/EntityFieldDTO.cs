using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class EntityFieldDTO : BaseDomain
    {
        public EntityFieldDTO()
        {
            EntityRelationships = new HashSet<EntityRelationshipDTO>();
            FormSectionFields = new HashSet<FormSectionFieldDTO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int FieldTypeId { get; set; }
        public int EntityId { get; set; }
        public string Settings { get; set; }
        public string? Instructions { get; set; }


        public  EntityDTO Entity { get; set; }
        public  ICollection<EntityRelationshipDTO> EntityRelationships { get; set; }
        public  ICollection<FormSectionFieldDTO> FormSectionFields { get; set; }
    }
}
