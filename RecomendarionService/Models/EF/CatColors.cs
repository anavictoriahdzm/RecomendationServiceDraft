﻿using System;
using System.Collections.Generic;

namespace RecomendarionService.Models.EF
{
    public partial class CatColors
    {
        public CatColors()
        {
            Products = new HashSet<Products>();
        }

        public int IdColor { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string HexaDecimal { get; set; }
        public bool IsEnable { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
