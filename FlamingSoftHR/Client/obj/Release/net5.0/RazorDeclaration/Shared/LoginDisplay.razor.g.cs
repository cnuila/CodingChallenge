// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FlamingSoftHR.Client.Shared
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
using FlamingSoftHR.Client.Pages.Employees;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using FlamingSoftHR.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Shared/LoginDisplay.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Shared/LoginDisplay.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Shared/LoginDisplay.razor"
      
    private async Task BeginSignOut(MouseEventArgs args)
    {
        await SignOutManager.SetSignOutState();
        Navigation.NavigateTo("authentication/logout");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignOutSessionStateManager SignOutManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
