using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class CountryDTO : BaseDomain
    {
        public CountryDTO()
        {
            Cities = new HashSet<CityDTO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Isocode2 { get; set; }
        public string Isocode3 { get; set; }
        public string PhoneCode { get; set; }
        public string NumericCode { get; set; }
        public int? OldCountryId { get; set; }

        public  ICollection<CityDTO> Cities { get; set; }
    }
}
