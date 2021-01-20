using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class StageFormDTO : BaseDomain
    {
        public int StageId { get; set; }
        public int FormId { get; set; }
        public int OrderNumber { get; set; }

        public  FormDTO Form { get; set; }
       // public  StageDTO Stage { get; set; }
    }
}
