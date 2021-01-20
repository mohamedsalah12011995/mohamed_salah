using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class Forms
    {
        public Forms()
        {
            ActionForms = new HashSet<ActionForms>();
            FormSections = new HashSet<FormSections>();
            StageForms = new HashSet<StageForms>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Settings { get; set; }

        public virtual ICollection<ActionForms> ActionForms { get; set; }
        public virtual ICollection<FormSections> FormSections { get; set; }
        public virtual ICollection<StageForms> StageForms { get; set; }
    }
}
