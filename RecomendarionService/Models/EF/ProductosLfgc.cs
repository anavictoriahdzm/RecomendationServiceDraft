using System;
using System.Collections.Generic;

namespace RecomendarionService.Models.EF
{
    public partial class ProductosLfgc
    {
        public int Id { get; set; }
        public string Talla { get; set; }
        public string Tipo { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Provider { get; set; }
        public string Temporada { get; set; }
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
    }
}
