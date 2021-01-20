using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class FormSectionAttachmentDTO : BaseDomain
    {
        public FormSectionAttachmentDTO()
        {
            AttachmentConstraints = new HashSet<AttachmentConstraintDTO>();
        }

        public int Id { get; set; }
        public int AttachmentTypeId { get; set; }
        public string Name { get; set; }
        public int FormSectionId { get; set; }
        public string Description { get; set; }
        public int OrderNumber { get; set; }

        public  FormSectionDTO FormSection { get; set; }
        public  ICollection<AttachmentConstraintDTO> AttachmentConstraints { get; set; }
    }
}
