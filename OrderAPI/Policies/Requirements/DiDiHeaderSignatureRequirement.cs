using Microsoft.AspNetCore.Authorization;

namespace OrderAPI.Policies.Requirements
{
    public class DiDiHeaderSignatureRequirement : IAuthorizationRequirement
    {
        public DiDiHeaderSignatureRequirement(string appSecret)
        {
            AppSecret = appSecret ?? throw new ArgumentNullException(nameof(appSecret));
        }

        public string AppSecret { get; }
    }


}
