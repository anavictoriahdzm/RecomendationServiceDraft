using System;
using System.Collections.Generic;

namespace RecomendarionService.Models.EF
{
    public partial class CatRatings
    {
        public CatRatings()
        {
            Comments = new HashSet<Comments>();
            Qualification = new HashSet<Qualification>();
        }

        public int IdRating { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<Qualification> Qualification { get; set; }
    }
}
