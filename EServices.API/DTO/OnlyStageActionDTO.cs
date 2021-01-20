using System;
using System.Collections.Generic;
using System.Text;

namespace Eservices.API.DTO
{
    public class OnlyStageActionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ActionTypeId { get; set; }
        public int OrderNumber { get; set; }
        public int StageId { get; set; }
    }
}
