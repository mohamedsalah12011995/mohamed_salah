using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class Applications
    {
        public Applications()
        {
            ApplicationStages = new HashSet<ApplicationStages>();
            InverseParentApplication = new HashSet<Applications>();
        }

        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int CreatorId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int DeviceTypeId { get; set; }
        public string ApplicationNumber { get; set; }
        public string UserAgent { get; set; }
        public string ClientIpaddress { get; set; }
        public int? ParentApplicationId { get; set; }

        public virtual Users Creator { get; set; }
        public virtual DeviceTypes DeviceType { get; set; }
        public virtual Applications ParentApplication { get; set; }
        public virtual Services Service { get; set; }
        public virtual ICollection<ApplicationStages> ApplicationStages { get; set; }
        public virtual ICollection<Applications> InverseParentApplication { get; set; }
    }
}
