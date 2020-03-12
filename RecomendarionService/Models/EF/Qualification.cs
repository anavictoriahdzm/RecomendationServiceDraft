using System;
using System.Collections.Generic;

namespace RecomendarionService.Models.EF
{
    public partial class Qualification
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public int IdRating { get; set; }
        public int Count { get; set; }
        public DateTime DateUpdate { get; set; }

        public virtual Products IdProductNavigation { get; set; }
        public virtual CatRatings IdRatingNavigation { get; set; }
    }
}
