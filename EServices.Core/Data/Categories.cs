using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class Categories
    {
        public Categories()
        {
            CategoryNotifyBodies = new HashSet<CategoryNotifyBodies>();
            SubCategories = new HashSet<SubCategories>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? OldId { get; set; }
        public int SectionId { get; set; }

        public virtual Sections Section { get; set; }
        public virtual ICollection<CategoryNotifyBodies> CategoryNotifyBodies { get; set; }
        public virtual ICollection<SubCategories> SubCategories { get; set; }
    }
}
