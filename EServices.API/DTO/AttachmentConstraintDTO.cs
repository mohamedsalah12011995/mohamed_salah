using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class AttachmentConstraintDTO : BaseDomain
    {
        public int FormSectionAttachmentId { get; set; }
        public int AttachmentConstraintTypeId { get; set; }
        public string Settings { get; set; }

        public  FormSectionAttachmentDTO FormSectionAttachment { get; set; }
    }
}
