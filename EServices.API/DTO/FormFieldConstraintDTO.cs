using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class FormFieldConstraintDTO : BaseDomain
    {
        public int Id { get; set; }
        public int FormSectionFieldId { get; set; }
        public int? FieldConstraintTypeId { get; set; }
        public string Settings { get; set; }

        public  FormSectionFieldDTO FormSectionField { get; set; }
    }
}
