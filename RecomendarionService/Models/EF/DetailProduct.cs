using System;
using System.Collections.Generic;

namespace RecomendarionService.Models.EF
{
    public partial class DetailProduct
    {
        public int IdDetail { get; set; }
        public int IdProduct { get; set; }
        public int IdTypeDetail { get; set; }
        public string Description { get; set; }
        public string DateUpdate { get; set; }

        public virtual Products IdProductNavigation { get; set; }
        public virtual CatTypeDetails IdTypeDetailNavigation { get; set; }
    }
}
