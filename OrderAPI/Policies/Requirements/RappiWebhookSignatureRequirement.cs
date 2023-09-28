using Microsoft.AspNetCore.Authorization;

namespace OrderAPI.Policies.Requirements
{
    public class RappiWebhookSignatureRequirement : IAuthorizationRequirement
    {
        public RappiWebhookSignatureRequirement(string secret)
        {
            Secret = secret ?? throw new ArgumentNullException(nameof(secret));
        }

        public string Secret { get; }
    }

}
