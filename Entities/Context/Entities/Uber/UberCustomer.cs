﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class UberCustomer
    {
        [Key]
        public string? id { get; set; }
        public Name name { get; set; }
        public OrderHistory order_history { get; set; }
        public virtual Contact contact { get; set; }
        public bool is_primary_customer { get; set; }
        public virtual TaxProfile tax_profile { get; set; }
        public bool can_response_to_fulfillment_issues { get; set; }
    }
}