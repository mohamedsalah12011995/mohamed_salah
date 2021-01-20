using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class CityDTO : BaseDomain
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CountryId { get; set; }

        public  CountryDTO Country { get; set; }
    }
}
