﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Didi
{
    public class PromotionDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int promo_type { get; set; }
        public int promo_discount { get; set; }
        public int shop_subside_price { get; set; }
    }


}
