using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int Id { get; set; }

    }
}
