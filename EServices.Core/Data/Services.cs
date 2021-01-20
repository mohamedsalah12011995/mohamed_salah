using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class Services
    {
        public Services()
        {
            Applications = new HashSet<Applications>();
            Stages = new HashSet<Stages>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }
        public int OrderNumber { get; set; }
        public string Description { get; set; }
        public string Settings { get; set; }

        public virtual Groups Group { get; set; }
        public virtual ICollection<Applications> Applications { get; set; }
        public virtual ICollection<Stages> Stages { get; set; }
    }
}
