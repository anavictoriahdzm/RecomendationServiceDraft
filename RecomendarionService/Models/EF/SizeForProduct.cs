using System;
using System.Collections.Generic;

namespace RecomendarionService.Models.EF
{
    public partial class SizeForProduct
    {
        public int IdSizeProduct { get; set; }
        public int IdProduct { get; set; }
        public int IdSize { get; set; }

        public virtual Products IdProductNavigation { get; set; }
        public virtual CatSizes IdSizeNavigation { get; set; }
    }
}
