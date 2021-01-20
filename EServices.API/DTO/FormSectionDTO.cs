using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class FormSectionDTO : BaseDomain
    {
        public FormSectionDTO()
        {
            FormSectionAttachments = new HashSet<FormSectionAttachmentDTO>();
            FormSectionFields = new HashSet<FormSectionFieldDTO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int FormId { get; set; }
        public int OrderNumber { get; set; }
        public string Settings { get; set; }
        public bool MultiPleRecords { get; set; }

        public  FormDTO Form { get; set; }
        public  ICollection<FormSectionAttachmentDTO> FormSectionAttachments { get; set; }
        public  ICollection<FormSectionFieldDTO> FormSectionFields { get; set; }
    }
}
