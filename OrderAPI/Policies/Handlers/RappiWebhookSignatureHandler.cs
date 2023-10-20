using Microsoft.AspNetCore.Authorization;
using OrderAPI.Policies.Requirements;
using System.Text;

namespace OrderAPI.Policies.Handlers
{
    public class RappiWebhookSignatureHandler : AuthorizationHandler<RappiWebhookSignatureRequirement>
    {
        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, RappiWebhookSignatureRequirement requirement)
        {
            // Implement signature validation logic here
            var request = context.Resource as HttpContext;
            if (request == null)
            {
                context.Fail();
                return;
            }

            // Extract timestamp and signature from the header
            string headerValue = request.Request.Headers["rappi-signature"];
            if (string.IsNullOrEmpty(headerValue))
            {
                context.Fail();
                return;
            }
            string[] elements = headerValue.Split(',');

            // Extract timestamp and signature
            if (elements.Length != 2)
            {
                context.Fail();
                return;
            }

            string timestamp = elements[0].Split('=')[1].Trim();
            string signature = elements[1].Split('=')[1].Trim();

            // Read the request body
            request.Request.EnableBuffering();
            var requestBody = await request.Request.BodyReader.ReadAsync();
            var str = Encoding.UTF8.GetString(requestBody.Buffer);
            request.Request.Body.Position = 0;

            // Create the signed_payload string
            string signedPayload = timestamp + "." + str;

            // Compute HMAC with SHA256
            using var hmac = new System.Security.Cryptography.HMACSHA256(Encoding.UTF8.GetBytes(requirement.Secret));
            byte[] hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(signedPayload));
            string expectedSignature = hashBytes.Aggregate("", (s, e) => s + String.Format("{0:x2}", e), s => s);

            // Compare the signature in the header with the expected signature
            if (!string.Equals(signature, expectedSignature))
            {
                context.Fail();
                return;
            }
            context.Succeed(requirement);
        }

    }

}
