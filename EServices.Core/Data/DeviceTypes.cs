using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class DeviceTypes
    {
        public DeviceTypes()
        {
            Applications = new HashSet<Applications>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Applications> Applications { get; set; }
    }
}
