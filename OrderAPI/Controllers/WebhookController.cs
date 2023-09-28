using Entities.Context.Entities.Rappi;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrderAPI.Repositories.Interfaces;

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
        [Authorize(Policy = "RappiWebhookSignaturePolicy")]
        public IActionResult HandleWebhookEvent([FromBody] dynamic payload)
        {
            var order = payload.order_detail as RappiOrder;

            if (order == null)
            {
                return BadRequest();
            }

            _orders.StoreRappiOrder(order);

            return Ok();
        }

    }
}
