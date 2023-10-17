using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Context.Entities.Uber
{
    public class OAuthToken
    {
        [Key]
        public int Id { get; set; }
        public string AccessToken { get; set; }
        public DateTime ExpirationTime { get; set; }
    }

}
