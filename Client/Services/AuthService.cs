using System.Net.Http.Json;
using System.Security.Claims;

namespace RadzenBlazorAzureStaticWebApp.Services
{
    public class AuthService(HttpClient httpClient)
    {
        private readonly HttpClient _httpClient = httpClient;

        public async Task<ClientPrincipal?> GetUserInfoAsync()
        {
            var response = await _httpClient.GetAsync("./.auth/me");
            if (response.IsSuccessStatusCode)
            {
                var payload = await response.Content.ReadFromJsonAsync<AuthInfo>();
                return payload?.ClientPrincipal;
            }

            return null;
        }
    }

    public class AuthInfo
    {
        public ClientPrincipal? ClientPrincipal { get; set; }
    }

    public class ClientPrincipal
    {
        public string? IdentityProvider { get; set; }
        public string? UserId { get; set; }
        public string? UserDetails { get; set; }
        public IEnumerable<string>? UserRoles { get; set; }
        public IEnumerable<Claim>? Claims { get; set; }
        public bool IsAuthenticated => Claims != null && Claims.Any();
    }
}