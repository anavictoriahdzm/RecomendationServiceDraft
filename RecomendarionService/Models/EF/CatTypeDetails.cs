using System;
using System.Collections.Generic;

namespace RecomendarionService.Models.EF
{
    public partial class CatTypeDetails
    {
        public CatTypeDetails()
        {
            DetailProduct = new HashSet<DetailProduct>();
        }

        public int IdTypeDetail { get; set; }
        public int IdType { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual CatTypeProduct IdTypeNavigation { get; set; }
        public virtual ICollection<DetailProduct> DetailProduct { get; set; }
    }
}
