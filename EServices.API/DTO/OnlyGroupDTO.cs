using System;
using System.Collections.Generic;
using System.Text;

namespace Eservices.API.DTO
{
    public class OnlyGroupDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public int OrderNumber { get; set; }
        public string Description { get; set; }
    }
}
