﻿using System;
using System.Collections.Generic;

namespace EServices.Core.Data
{
    public partial class TranslationKeys
    {
        public TranslationKeys()
        {
            Translations = new HashSet<Translations>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Translations> Translations { get; set; }
    }
}
