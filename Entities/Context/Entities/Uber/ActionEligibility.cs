﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class ActionEligibility
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool can_adjust_ready_for_pickup_time { get; set; }
        public bool can_mark_out_of_item { get; set; }
        public bool cancel { get; set; }
    }
}