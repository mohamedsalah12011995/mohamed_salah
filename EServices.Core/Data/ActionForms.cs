using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class ActionForms
    {
        public int ActionId { get; set; }
        public int FormId { get; set; }
        public int OrderNumber { get; set; }

        public virtual ActionTypes Action { get; set; }
        public virtual Forms Form { get; set; }
    }
}
