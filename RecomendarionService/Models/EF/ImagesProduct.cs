using System;
using System.Collections.Generic;

namespace RecomendarionService.Models.EF
{
    public partial class ImagesProduct
    {
        public int IdImage { get; set; }
        public int IdImageProduct { get; set; }
        public string Decription { get; set; }
        public byte[] Image { get; set; }
        public string DateUpdate { get; set; }
        public string IsEnabled { get; set; }

        public virtual Products IdImageProductNavigation { get; set; }
    }
}
