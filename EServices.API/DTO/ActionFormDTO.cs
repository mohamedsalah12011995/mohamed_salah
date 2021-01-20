using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class ActionFormDTO : BaseDomain
    {
        public int ActionId { get; set; }
        public int FormId { get; set; }
        public int OrderNumber { get; set; }

        public  ActionTypeDTO Action { get; set; }
        public  FormDTO Form { get; set; }
    }
}
