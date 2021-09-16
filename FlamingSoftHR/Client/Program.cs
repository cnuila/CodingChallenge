using FlamingSoftHR.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FlamingSoftHR.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddHttpClient<IEmployeeService, EmployeeService>(client => {
                client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
            });

            //builder.Services.AddHttpClient("FlamingSoftHR.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
            //    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("FlamingSoftHR.ServerAPI"));

            builder.Services.AddApiAuthorization();

            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTAxMjQ1QDMxMzkyZTMyMmUzME4vd051UnBRVGFIT0MxbVpYTS93Q0ErZms4eWxIcTlHNWlxOEpzSW9JL0k9;NTAxMjQ2QDMxMzkyZTMyMmUzMGJ5bkkwMWJXcjI4akwrYUhBOTQzaXBORWsxT0ZMRVhHZlhFZ2JxcldYOE09;NTAxMjQ3QDMxMzkyZTMyMmUzMEtWNHppcW9GZjdNOThlZURHaGdIRUs2VVJlNVZxelJNa2pwdDVFUUhGTFE9;NTAxMjQ4QDMxMzkyZTMyMmUzMGJteVN0SE8zSlUvYm44Q1dvUXB4c3VjejMxQjZuU0pVMnNrZ1Q1NXpRTEk9;NTAxMjQ5QDMxMzkyZTMyMmUzMFlJSjdkS1pRem9XZkVWN011ekd0Ry9FcExDdWRaM3lSYTVNTlJJRm9Fc0U9;NTAxMjUwQDMxMzkyZTMyMmUzMEFQZU1FZElMb2pNVStuL0wySWNSZXlwUW1rcG5HUFNqN0E2NFhvUHAzYWs9;NTAxMjUxQDMxMzkyZTMyMmUzMGdxdVJzWDN4QlVlb1g2bWFMY1E0UnhiQyt6K25DMVFmanFZWG9UQmxwWnM9;NTAxMjUyQDMxMzkyZTMyMmUzMFYzNHByMkxsMEZESTY2MjZBWGtuUThEcDNHcDQvWk9NVGsvMHZHYjF4RTA9;NTAxMjUzQDMxMzkyZTMyMmUzMG9BY3hJeDJYTmpPa3ZURTZaVzkyY2gxdmdVSlVqU0ZrejlMa0U3Q0piYVU9;NTAxMjU0QDMxMzkyZTMyMmUzMGtJZ2NBNW1BMXhNVDVhOUtLeE1jWEg5RGJvcXV5T3YxTmNTbFppMFByWEE9");
            //builder.Services.AddSyncfusionBlazor();
            builder.Services.AddMudServices();

            await builder.Build().RunAsync();
        }
    }
}
