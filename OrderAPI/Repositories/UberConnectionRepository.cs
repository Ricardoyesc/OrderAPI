using Entities.Context;
using Entities.Context.Entities.Uber;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using OrderAPI.Configuration;
using OrderAPI.Repositories.Interfaces;
using RestSharp;
using Serilog;
using System.Text.Json;

namespace OrderAPI.Repositories
{
    public class UberConnectionRepository : IUberConnection
    {
        private readonly IOrdersRepository _orders;
        private readonly UberConfiguration _uberConfig;
        private readonly RestClient _client;
        private readonly DatabaseContext _context;

        public UberConnectionRepository(IOptions<UberConfiguration> uberConfig, DatabaseContext context, IOrdersRepository orders)
        {
            _uberConfig = uberConfig.Value;
            _client = new RestClient();
            _context = context;
            _orders = orders;
        }

        private async Task<string> GetAccessTokenAsync()
        {
            var now = DateTime.UtcNow;
            var storedToken = await _context.OAuthTokens.OrderBy(x => x.ExpirationTime).FirstOrDefaultAsync();

            if (storedToken != null && storedToken.ExpirationTime > now)
            {
                return storedToken.AccessToken;
            }

            var clientId = _uberConfig.ClientId;
            var clientSecret = _uberConfig.ClientSecret;
            var scope = _uberConfig.Scope;
            var tokenUrl = _uberConfig.TokenUrl;

            var request = new RestRequest(tokenUrl, Method.Post);
            request.AddParameter("client_id", clientId);
            request.AddParameter("client_secret", clientSecret);
            request.AddParameter("grant_type", "client_credentials");
            request.AddParameter("scope", scope);

            var response = await _client.ExecuteAsync<OAuthTokenResponse>(request);

            if (response.IsSuccessful && response.Data != null)
            {
                storedToken = new OAuthToken
                {
                    AccessToken = response.Data.AccessToken,
                    ExpirationTime = now.AddSeconds(response.Data.ExpiresIn)
                };
                _context.OAuthTokens.Add(storedToken);
                _context.SaveChanges();

                return response.Data.AccessToken;
            }
            else
            {
                throw new Exception($"Error al obtener el token OAuth: {response.ErrorMessage}");
            }
        }


        public async Task HandleWebhook(UberWebhook webhook)
        {
            if (webhook.event_type == "orders.notification")
            {
                string token = await GetAccessTokenAsync();

                var request = new RestRequest(webhook.meta.resource_href, Method.Get);
                request.AddHeader("Authorization", $"Bearer {token}");

                var response = await _client.ExecuteAsync<UberOrder>(request);

                if (response.IsSuccessful && response.Data != null)
                {
                    await _orders.StoreUberOrder(response.Data);
                    return;
                }
                else
                {
                    Log.Information($"Error al realizar la solicitud: {response.ErrorMessage}");
                }
            }
            else
            {
                Log.Information($"Tipo de evento {webhook.event_type} no válido.");
            }
        }

    }

}
