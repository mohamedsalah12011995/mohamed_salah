using System;
using System.Collections.Generic;
using System.Text;

namespace Eservices.API.DTO
{
   public class FiledLookupDTO
    {
        public int Id { get; set; }
        public int? EntityFieldId { get; set; }
        public string Text { get; set; }
        public string Value { get; set; }
        public int? ParentID { get; set; }
        public  EntityFieldDTO EntityField { get; set; }
    }
}
