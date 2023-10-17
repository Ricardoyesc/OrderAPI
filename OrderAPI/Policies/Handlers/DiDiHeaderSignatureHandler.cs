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

            // Extract the header sign value
            string headerSign = request.Request.Headers["didi-header-sign"];

            // Read the request body
            request.Request.EnableBuffering();
            using var reader = new StreamReader(request.Request.Body);
            string requestBody = await reader.ReadToEndAsync();
            request.Request.Body.Position = 0;


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
    }

}
