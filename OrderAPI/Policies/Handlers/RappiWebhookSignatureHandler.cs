using Microsoft.AspNetCore.Authorization;
using OrderAPI.Policies.Requirements;

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
            using var reader = new StreamReader(request.Request.Body);
            string requestBody = await reader.ReadToEndAsync();

            // Create the signed_payload string
            string signedPayload = $"{timestamp}.{requestBody}";

            // Compute HMAC with SHA256
            using var hmac = new System.Security.Cryptography.HMACSHA256(Convert.FromBase64String(requirement.Secret));
            byte[] hashBytes = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(signedPayload));
            string expectedSignature = Convert.ToBase64String(hashBytes);

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
