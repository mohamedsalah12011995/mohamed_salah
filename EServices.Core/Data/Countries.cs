using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class Countries
    {
        public Countries()
        {
            Cities = new HashSet<Cities>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Isocode2 { get; set; }
        public string Isocode3 { get; set; }
        public string PhoneCode { get; set; }
        public string NumericCode { get; set; }
        public int? OldCountryId { get; set; }

        public virtual ICollection<Cities> Cities { get; set; }
    }
}
