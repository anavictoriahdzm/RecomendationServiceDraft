using System;
using System.Collections.Generic;

namespace RecomendarionService.Models.EF
{
    public partial class Products
    {
        public Products()
        {
            Comments = new HashSet<Comments>();
            DetailProduct = new HashSet<DetailProduct>();
            ImagesProduct = new HashSet<ImagesProduct>();
            Qualification = new HashSet<Qualification>();
            SimilarProduct = new HashSet<SimilarProduct>();
            SizeForProduct = new HashSet<SizeForProduct>();
        }

        public int Id { get; set; }
        public int? IdType { get; set; }
        public int? IdColor { get; set; }
        public int? IdBrand { get; set; }
        public int? IdProvider { get; set; }
        public int IdCatalog { get; set; }
        public string Title { get; set; }
        public string Nombre { get; set; }
        public string Description { get; set; }
        public string Observations { get; set; }
        public decimal? PriceDistributor { get; set; }
        public decimal PriceClient { get; set; }
        public decimal PriceMember { get; set; }
        public bool IsEnabled { get; set; }
        public string Keywords { get; set; }
        public DateTime DateUpdate { get; set; }

        public virtual CatBrands IdBrandNavigation { get; set; }
        public virtual CatCatalogs IdCatalogNavigation { get; set; }
        public virtual CatColors IdColorNavigation { get; set; }
        public virtual CatProviders IdProviderNavigation { get; set; }
        public virtual CatTypeProduct IdTypeNavigation { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<DetailProduct> DetailProduct { get; set; }
        public virtual ICollection<ImagesProduct> ImagesProduct { get; set; }
        public virtual ICollection<Qualification> Qualification { get; set; }
        public virtual ICollection<SimilarProduct> SimilarProduct { get; set; }
        public virtual ICollection<SizeForProduct> SizeForProduct { get; set; }
    }
}
