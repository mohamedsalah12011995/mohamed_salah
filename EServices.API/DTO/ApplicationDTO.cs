using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class ApplicationDTO : BaseDomain
    {
        public ApplicationDTO()
        {
            ApplicationStages = new HashSet<ApplicationStageDTO>();
            InverseParentApplication = new HashSet<ApplicationDTO>();
        }

        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int CreatorId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int DeviceTypeId { get; set; }
        public string ApplicationNumber { get; set; }
        public string UserAgent { get; set; }
        public string ClientIpaddress { get; set; }
        public int? ParentApplicationId { get; set; }

        public  UserDTO Creator { get; set; }
        public  ApplicationDTO ParentApplication { get; set; }
        public  ServiceDTO Service { get; set; }
        public  ICollection<ApplicationStageDTO> ApplicationStages { get; set; }
        public  ICollection<ApplicationDTO> InverseParentApplication { get; set; }
    }
}
