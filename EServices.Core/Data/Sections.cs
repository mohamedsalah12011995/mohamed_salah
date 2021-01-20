using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class Sections
    {
        public Sections()
        {
            Categories = new HashSet<Categories>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? OldId { get; set; }

        public virtual ICollection<Categories> Categories { get; set; }
    }
}
