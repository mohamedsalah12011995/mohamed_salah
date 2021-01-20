using System;
using System.Collections.Generic;
using System.Text;

namespace Eservices.API.DTO
{
    public class OnlyEntityFieldDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FieldTypeId { get; set; }
        public int EntityId { get; set; }
        public string Settings { get; set; }
    }
}
