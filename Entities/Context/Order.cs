﻿using System.ComponentModel.DataAnnotations.Schema;
using static Entities.Context.Entities.Catalogs;

namespace Entities.Context
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Provider provider { get; set; }
    }
}
