using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class ServiceDTO : BaseDomain
    {
        public ServiceDTO()
        {
            //Applications = new HashSet<ApplicationDTO>();
            Stages = new HashSet<StageDTO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }
        public int OrderNumber { get; set; }
        public string Description { get; set; }
        public string Settings { get; set; }

        //public  GroupDTO Group { get; set; }
        //public  ICollection<ApplicationDTO> Applications { get; set; }
        public  ICollection<StageDTO> Stages { get; set; }
    }
}
