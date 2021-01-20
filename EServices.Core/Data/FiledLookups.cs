using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EServices.Core.Data
{
   public class FiledLookups
    {
        public FiledLookups()
        {
            FiledLookupParents = new HashSet<FiledLookups>();
        }

        [Key]
        public int Id { get; set; }
        public int EntityFieldId { get; set; }
        public string Text { get; set; }
        public string Value { get; set; }
        public int? ParentID { get; set; }
        public virtual EntityFields EntityField { get; set; }

        // tis relation to Parent
        public virtual FiledLookups FiledLookupParent { get; set; }
        public virtual ICollection<FiledLookups> FiledLookupParents { get; set; }
    }
}
