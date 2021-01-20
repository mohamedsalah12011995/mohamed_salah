using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class NotifyBodies
    {
        public NotifyBodies()
        {
            CategoryNotifyBodies = new HashSet<CategoryNotifyBodies>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? OldId { get; set; }

        public virtual ICollection<CategoryNotifyBodies> CategoryNotifyBodies { get; set; }
    }
}
