#pragma checksum "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Shared/Navbar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0aa5c037ca75c39393329039f8ebb848f63eeaba"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class Navbar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudAppBar>(0);
            __builder.AddAttribute(1, "Class", "red darken-3");
            __builder.AddAttribute(2, "Fixed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 1 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Shared/Navbar.razor"
                                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudGrid>(4);
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudItem>(6);
                    __builder3.AddAttribute(7, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 3 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Shared/Navbar.razor"
                     2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudText>(9);
                        __builder4.AddAttribute(10, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 4 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Shared/Navbar.razor"
                           Typo.h5

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(11, "Class", "text-white");
                        __builder4.AddAttribute(12, "Style", "cursor:pointer");
                        __builder4.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Shared/Navbar.razor"
                                                                                        () => GoToHome()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(15, " FlamingSoft HR ");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(16, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(17);
                    __builder3.AddAttribute(18, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 6 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Shared/Navbar.razor"
                     10

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "Class", "d-flex justify-end");
                    __builder3.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<FlamingSoftHR.Client.Shared.LoginDisplay>(21);
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Shared/Navbar.razor"
       

    [Inject]
    public NavigationManager NavigationManager { get; set; }

    private void GoToHome()
    {

        NavigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
