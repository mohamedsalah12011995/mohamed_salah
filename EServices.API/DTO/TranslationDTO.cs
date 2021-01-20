using System;
using System.Collections.Generic;

namespace Eservices.API.DTO
{
    public partial class TranslationDTO : BaseDomain
    {
        public int TranslationKeyId { get; set; }
        public int LanguageId { get; set; }
        public int ItemId { get; set; }
        public string Value { get; set; }

        public  LanguageDTO Language { get; set; }
        public  TranslationKeyDTO TranslationKey { get; set; }
    }
}
