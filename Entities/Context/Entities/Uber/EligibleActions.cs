using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Entities.Context.Entities.Uber
{
    public class EligibleActions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public bool can_adjust_ready_for_pickup_time { get; set; }
        [AllowNull]
        public bool? can_mark_out_of_item { get; set; } = null;
        public bool cancel { get; set; }
    }
}