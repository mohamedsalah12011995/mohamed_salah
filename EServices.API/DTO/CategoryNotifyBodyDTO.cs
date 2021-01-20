using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class CategoryNotifyBodyDTO : BaseDomain
    {
        public int CategoryId { get; set; }
        public int NotifyBodyId { get; set; }
        public string NotifyBodyCertificate { get; set; }

        public  CategoryDTO Category { get; set; }
        public  NotifyBodyDTO NotifyBody { get; set; }
    }
}
