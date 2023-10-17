using Entities.Context.Entities.Didi;
using Entities.Context.Entities.Rappi;
using Entities.Context.Entities.Uber;
using Entities.Models;
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
        public async Task<IActionResult> RappiWebhookAsync([FromBody] JsonArray jObject)
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
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Consumes("application/json")]
        public async Task<ActionResult<DidiResponse>> DidiWebhookAsync([FromBody] DidiWebhook<DidiOrderModel> order)
        {
            try
            {

                if (order == null)
                {
                    return BadRequest();
                }
                await _orders.StoreDidiOrder(order.data.order_info);
                return Ok( new DidiResponse());
            }
            catch (Exception ex)
            {
                return BadRequest(new DidiResponse
                {
                    errno = 1,
                    errmessage = ex.Message + " | " + ex.StackTrace + " | " + ex.InnerException?.Message
                });
            }
        }

        [HttpPost]
        [Consumes("application/json")]
        public IActionResult UberWebhookAsync([FromBody] UberWebhook uberWebhook)
        {
            try
            {
                if (uberWebhook == null)
                {
                    return BadRequest();
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + " | " + ex.StackTrace + " | " + ex.InnerException?.Message);
            }
        }


    }
}
