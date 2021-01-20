using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class LanguageDTO : BaseDomain
    {
        public LanguageDTO()
        {
            Translations = new HashSet<TranslationDTO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public  ICollection<TranslationDTO> Translations { get; set; }
    }
}
