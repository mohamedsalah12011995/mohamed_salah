using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class TranslationKeyDTO : BaseDomain
    {
        public TranslationKeyDTO()
        {
            Translations = new HashSet<TranslationDTO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public  ICollection<TranslationDTO> Translations { get; set; }
    }
}
