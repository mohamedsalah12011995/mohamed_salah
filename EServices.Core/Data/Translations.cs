using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class Translations
    {
        public int TranslationKeyId { get; set; }
        public int LanguageId { get; set; }
        public int ItemId { get; set; }
        public string Value { get; set; }

        public virtual Languages Language { get; set; }
        public virtual TranslationKeys TranslationKey { get; set; }
    }
}
