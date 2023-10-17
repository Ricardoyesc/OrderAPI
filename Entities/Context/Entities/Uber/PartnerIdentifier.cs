﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class PartnerIdentifier
    {
        [Key]
        public string? id { get; set; }
        public string? type { get; set; }
    }
}