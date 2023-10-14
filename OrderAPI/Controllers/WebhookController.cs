using Entities.Context.Entities.Rappi;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrderAPI.Repositories.Interfaces;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace OrderAPI.Controllers
{
    [ApiController]
    [Route("api/webhook-handler/[action]")]
    public class WebhookController : ControllerBase
    {
        private readonly IOrdersRepository _orders;
        public WebhookController(IOrdersRepository orders)
        {
            _orders = orders;
        }
        [HttpPost]
        [Consumes("application/json")]
        [Authorize(Policy = "RappiWebhookSignaturePolicy")]
        public async Task<IActionResult> HandleWebhookEventAsync([FromBody] JsonArray jObject)
        {
            try
            {
                var order = jObject.First().Deserialize<RappiOrder>();

                if (order == null)
                {
                    return BadRequest();
                }

                await _orders.StoreRappiOrder(order);
                
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }

    }
}
