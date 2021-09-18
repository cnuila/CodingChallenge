// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FlamingSoftHR.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using FlamingSoftHR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using FlamingSoftHR.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using FlamingSoftHR.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using FlamingSoftHR.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/Login.razor"
       

    [Inject]
    public IAuthService AuthService { get; set; }

    [Inject]
    public NavigationManager NavigationManager { get; set; }

    private LoginModel loginModel= new LoginModel();

    private string error {get; set; }
    private bool success { get; set; }

    private async Task HandleLogin()
    {
        Console.Write("vasdas");

        var result = await AuthService.Login(loginModel);



        if (result.Successful)
        {
            NavigationManager.NavigateTo("/", forceLoad:true);
        }
        else
        {
            error = result.Error;
        }
    }




#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
