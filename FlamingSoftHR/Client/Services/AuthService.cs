using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using FlamingSoftHR.Shared;
using Microsoft.AspNetCore.Components.Authorization;

namespace FlamingSoftHR.Client.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient httpClient;
        private readonly AuthenticationStateProvider authenticationStateProvider;
        private readonly ILocalStorageService localStorageService;

        public AuthService(HttpClient httpClient, AuthenticationStateProvider authenticationStateProvider, ILocalStorageService localStorage)
        {
            this.httpClient = httpClient;
            this.authenticationStateProvider = authenticationStateProvider;
            this.localStorageService = localStorage;
        }

        public async Task<LoginDataResult> Login(LoginModel loginModel)
        {
            var loginAsJson = JsonSerializer.Serialize(loginModel);
            var response = await httpClient.PostAsync("api/Login", new StringContent(loginAsJson, Encoding.UTF8, "application/json"));
            var loginResult = JsonSerializer.Deserialize<LoginDataResult>(await response.Content.ReadAsStringAsync(),
                                                                          new JsonSerializerOptions {
                                                                               PropertyNameCaseInsensitive = true
                                                                          });
            if (!response.IsSuccessStatusCode)
            {
                return loginResult;
            }

            await localStorageService.SetItemAsync("authToken", loginResult.Token);

            ((ApiAuthenticationStateProvider)authenticationStateProvider).MarkUserAsAuthenticated(loginModel.Email);
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", loginResult.Token);

            return loginResult;
        }

        public async Task Logout()
        {
            await localStorageService.RemoveItemAsync("authToken");

            ((ApiAuthenticationStateProvider)authenticationStateProvider).MarkUserAsLoggedOut();
            httpClient.DefaultRequestHeaders.Authorization = null;
        }

        public async Task<RegisterDataResult> Register(RegisterModel registerModel)
        {
            var result = await httpClient.PostAsJsonAsync("api/accounts", registerModel);

            return await result.Content.ReadFromJsonAsync<RegisterDataResult>();
        }
    }
}
