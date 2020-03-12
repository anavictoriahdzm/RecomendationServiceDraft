using System;
using System.Collections.Generic;

namespace RecomendarionService.Models.EF
{
    public partial class Cards
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string CreditCard { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string IdNumber { get; set; }
    }
}
