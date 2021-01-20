using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class CategoryNotifyBodies
    {
        public int CategoryId { get; set; }
        public int NotifyBodyId { get; set; }
        public string NotifyBodyCertificate { get; set; }

        public virtual Categories Category { get; set; }
        public virtual NotifyBodies NotifyBody { get; set; }
    }
}
