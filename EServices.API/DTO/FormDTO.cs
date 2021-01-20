using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class FormDTO : BaseDomain
    {
        public FormDTO()
        {
            //ActionForms = new HashSet<ActionFormDTO>();
            FormSections = new HashSet<FormSectionDTO>();
            //StageForms = new HashSet<StageFormDTO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Settings { get; set; }

        //public  ICollection<ActionFormDTO> ActionForms { get; set; }
        public  ICollection<FormSectionDTO> FormSections { get; set; }
        //public  ICollection<StageFormDTO> StageForms { get; set; }
    }
}
