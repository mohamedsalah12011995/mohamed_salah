using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class FormSectionFieldDTO : BaseDomain
    {
        public FormSectionFieldDTO()
        {
            FormFieldConstraints = new HashSet<FormFieldConstraintDTO>();
        }

        public int Id { get; set; }
        public int FormSectionId { get; set; }
        public int OrderNumber { get; set; }
        public int EntityFieldId { get; set; }

        public  EntityFieldDTO EntityField { get; set; }
        public  FormSectionDTO FormSection { get; set; }
        public  ICollection<FormFieldConstraintDTO> FormFieldConstraints { get; set; }
    }
}
