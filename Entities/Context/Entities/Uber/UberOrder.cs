using System.Text.Json.Serialization;

namespace Entities.Context.Entities.Uber
{
    public partial class UberOrder
    {
        public int id { get; set; }

        [JsonIgnore]
        public Order order { get; set; } = new Order() { provider = Catalogs.Provider.DIDI };
    }
}