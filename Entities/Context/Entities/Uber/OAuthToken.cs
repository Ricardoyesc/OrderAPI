using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Context.Entities.Uber
{
    public class OAuthToken
    {
        [Key]
        public int Id { get; set; }
        public string? AccessToken { get; set; }
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime ExpirationTime { get; set; }
    }

}
