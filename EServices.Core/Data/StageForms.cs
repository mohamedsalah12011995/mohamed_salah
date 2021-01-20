using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class StageForms
    {
        public int StageId { get; set; }
        public int FormId { get; set; }
        public int OrderNumber { get; set; }

        public virtual Forms Form { get; set; }
        public virtual Stages Stage { get; set; }
    }
}
