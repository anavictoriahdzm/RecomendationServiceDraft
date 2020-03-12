using System;
using System.Collections.Generic;

namespace RecomendarionService.Models.EF
{
    public partial class CatProviders
    {
        public CatProviders()
        {
            CatCatalogs = new HashSet<CatCatalogs>();
            Products = new HashSet<Products>();
        }

        public int IdProvider { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IsEnabled { get; set; }
        public DateTime DateUpdate { get; set; }
        public string Url { get; set; }

        public virtual ICollection<CatCatalogs> CatCatalogs { get; set; }
        public virtual ICollection<Products> Products { get; set; }
    }
}
