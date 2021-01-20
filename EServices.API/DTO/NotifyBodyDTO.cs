using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class NotifyBodyDTO : BaseDomain
    {
        public NotifyBodyDTO()
        {
            CategoryNotifyBodies = new HashSet<CategoryNotifyBodyDTO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? OldId { get; set; }

        public  ICollection<CategoryNotifyBodyDTO> CategoryNotifyBodies { get; set; }
    }
}
