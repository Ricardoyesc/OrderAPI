using Microsoft.AspNetCore.Authorization;
using OrderAPI.Policies.Requirements;
using System.Security.Cryptography;
using System.Text;

namespace OrderAPI.Policies.Handlers
{
    public class DiDiHeaderSignatureHandler : AuthorizationHandler<DiDiHeaderSignatureRequirement>
    {
        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, DiDiHeaderSignatureRequirement requirement)
        {
            var request = context.Resource as HttpContext;
            if (request == null)
            {
                context.Fail();
                return;
            }

            request.Request.EnableBuffering();

            // Extract the header sign value
            string headerSign = request.Request.Headers["didi-header-sign"];

            // Read the request body into a MemoryStream
            using (var memoryStream = new MemoryStream())
            {
                await request.Request.Body.CopyToAsync(memoryStream);
                memoryStream.Seek(0, SeekOrigin.Begin);

                // Convert the MemoryStream content to a string
                string requestBody = Encoding.UTF8.GetString(memoryStream.ToArray());

                // Calculate the expected signature
                string expectedSignature;

                // In this example, we'll use MD5 for signature calculation
                using (var md5 = MD5.Create())
                {
                    // Concatenate the request body and app secret
                    string signStr = requestBody + requirement.AppSecret;
                    byte[] hashBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(signStr));
                    expectedSignature = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                }

                // Compare the header sign with the expected signature
                if (string.Equals(headerSign, expectedSignature, StringComparison.OrdinalIgnoreCase))
                {
                    context.Succeed(requirement);
                }
                else
                {
                    context.Fail();
                }
            }
            request.Request.Body.Position = 0;
        }
    }
}
