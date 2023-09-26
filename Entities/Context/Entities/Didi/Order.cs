using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Didi
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int Id { get; set; }

    }
}
