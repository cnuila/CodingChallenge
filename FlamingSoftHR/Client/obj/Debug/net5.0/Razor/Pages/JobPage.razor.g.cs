#pragma checksum "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/JobPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02f085065f93c8a4d44521a38004a59224b2fd7d"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/jobs")]
    public partial class JobPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudGrid>(0);
            __builder.AddAttribute(1, "Justify", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Justify>(
#nullable restore
#line 3 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/JobPage.razor"
                  Justify.Center

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudItem>(3);
                __builder2.AddAttribute(4, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 4 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/JobPage.razor"
                 12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "Class", "pa-8");
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudGrid>(7);
                    __builder3.AddAttribute(8, "Justify", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Justify>(
#nullable restore
#line 6 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/JobPage.razor"
                          Justify.FlexStart

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudItem>(10);
                        __builder4.AddAttribute(11, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 7 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/JobPage.razor"
                         7

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudPaper>(13);
                            __builder5.AddAttribute(14, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/JobPage.razor"
                                     4

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(15, "Class", "grey lighten-4 pa-7 red-text text-darken-2");
                            __builder5.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudGrid>(17);
                                __builder6.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudItem>(19);
                                    __builder7.AddAttribute(20, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/JobPage.razor"
                                     7

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.OpenComponent<MudBlazor.MudText>(22);
                                        __builder8.AddAttribute(23, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 13 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/JobPage.razor"
                                           Typo.h4

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.AddContent(25, " Jobs ");
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(26, "\n\n                        ");
                                    __builder7.OpenComponent<MudBlazor.MudItem>(27);
                                    __builder7.AddAttribute(28, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/JobPage.razor"
                                     5

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(29, "Class", "d-flex justify-end");
                                    __builder7.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.OpenComponent<MudBlazor.MudButton>(31);
                                        __builder8.AddAttribute(32, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 17 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/JobPage.razor"
                                                Variant.Filled

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(33, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 17 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/JobPage.razor"
                                                                      Size.Medium

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(34, "Class", "red darken-2 white-text");
                                        __builder8.AddAttribute(35, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/JobPage.razor"
                                                                                                                             OpenAddJob

#line default
#line hidden
#nullable disable
                                        )));
                                        __builder8.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.AddContent(37, " Add ");
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(38, "\n\n                        ");
                                    __builder7.OpenComponent<MudBlazor.MudItem>(39);
                                    __builder7.AddAttribute(40, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 20 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/JobPage.razor"
                                     12

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __Blazor.FlamingSoftHR.Client.Pages.JobPage.TypeInference.CreateMudTable_0(__builder8, 42, 43, 
#nullable restore
#line 21 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/JobPage.razor"
                                             true

#line default
#line hidden
#nullable disable
                                        , 44, 
#nullable restore
#line 21 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/JobPage.razor"
                                                           jobs

#line default
#line hidden
#nullable disable
                                        , 45, 
#nullable restore
#line 21 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/JobPage.razor"
                                                                             Breakpoint.Sm

#line default
#line hidden
#nullable disable
                                        , 46, 
#nullable restore
#line 21 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/JobPage.razor"
                                                                                                      loading

#line default
#line hidden
#nullable disable
                                        , 47, 
#nullable restore
#line 21 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/JobPage.razor"
                                                                                                                                     Color.Error

#line default
#line hidden
#nullable disable
                                        , 48, (__builder9) => {
                                            __builder9.OpenComponent<MudBlazor.MudTh>(49);
                                            __builder9.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder10) => {
                                                __builder10.AddContent(51, " Id ");
                                            }
                                            ));
                                            __builder9.CloseComponent();
                                            __builder9.AddMarkupContent(52, "\n                                    ");
                                            __builder9.OpenComponent<MudBlazor.MudTh>(53);
                                            __builder9.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder10) => {
                                                __builder10.AddContent(55, " Description ");
                                            }
                                            ));
                                            __builder9.CloseComponent();
                                            __builder9.AddMarkupContent(56, "\n                                    ");
                                            __builder9.OpenComponent<MudBlazor.MudTh>(57);
                                            __builder9.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder10) => {
                                                __builder10.AddContent(59, " Department ");
                                            }
                                            ));
                                            __builder9.CloseComponent();
                                            __builder9.AddMarkupContent(60, "\n                                    ");
                                            __builder9.OpenComponent<MudBlazor.MudTh>(61);
                                            __builder9.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder10) => {
                                                __builder10.AddContent(63, " Actions  ");
                                            }
                                            ));
                                            __builder9.CloseComponent();
                                        }
                                        , 64, (context) => (__builder9) => {
                                            __builder9.OpenComponent<MudBlazor.MudTd>(65);
                                            __builder9.AddAttribute(66, "DataLabel", "Id");
                                            __builder9.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder10) => {
                                                __builder10.AddContent(68, 
#nullable restore
#line 30 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/JobPage.razor"
                                                            context.Id

#line default
#line hidden
#nullable disable
                                                );
                                            }
                                            ));
                                            __builder9.CloseComponent();
                                            __builder9.AddMarkupContent(69, "\n                                    ");
                                            __builder9.OpenComponent<MudBlazor.MudTd>(70);
                                            __builder9.AddAttribute(71, "DataLabel", "Description");
                                            __builder9.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder10) => {
                                                __builder10.AddContent(73, 
#nullable restore
#line 31 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/JobPage.razor"
                                                                    context.Description

#line default
#line hidden
#nullable disable
                                                );
                                            }
                                            ));
                                            __builder9.CloseComponent();
                                            __builder9.AddMarkupContent(74, "\n                                    ");
                                            __builder9.OpenComponent<MudBlazor.MudTd>(75);
                                            __builder9.AddAttribute(76, "DataLabel", "Department");
                                            __builder9.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder10) => {
                                                __builder10.AddContent(78, 
#nullable restore
#line 32 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/JobPage.razor"
                                                                   context.DepartmentId

#line default
#line hidden
#nullable disable
                                                );
                                            }
                                            ));
                                            __builder9.CloseComponent();
                                            __builder9.AddMarkupContent(79, "\n                                    ");
                                            __builder9.OpenComponent<MudBlazor.MudTd>(80);
                                            __builder9.AddAttribute(81, "DataLabel", "Action");
                                            __builder9.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder10) => {
                                                __builder10.AddContent(83, "0");
                                            }
                                            ));
                                            __builder9.CloseComponent();
                                        }
                                        , 84, (__builder9) => {
                                            __builder9.OpenComponent<MudBlazor.MudTablePager>(85);
                                            __builder9.CloseComponent();
                                        }
                                        );
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
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
#line 52 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/JobPage.razor"
       

    [Inject]
    public IDialogService DialogService { get; set; }

    [Inject]
    public IJobService JobService{ get; set; }

    private List<Job> jobs { get; set; }
    private bool loading = true;

    // load jobs, once loaded loading the animation stops
    protected async override Task OnInitializedAsync()
    {
        jobs = (await JobService.GetJobs()).ToList();
        Console.WriteLine(jobs);
        loading = false;
    }

    private void OpenAddJob()
    {
        var parameters = new DialogParameters();
        parameters.Add("FieldName", "Description");

        DialogService.Show<AddUpdateSimple>("Add Job", parameters);
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.FlamingSoftHR.Client.Pages.JobPage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Collections.Generic.IEnumerable<T> __arg1, int __seq2, global::MudBlazor.Breakpoint __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::MudBlazor.Color __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment __arg7)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Hover", __arg0);
        __builder.AddAttribute(__seq1, "Items", __arg1);
        __builder.AddAttribute(__seq2, "Breakpoint", __arg2);
        __builder.AddAttribute(__seq3, "Loading", __arg3);
        __builder.AddAttribute(__seq4, "LoadingProgressColor", __arg4);
        __builder.AddAttribute(__seq5, "HeaderContent", __arg5);
        __builder.AddAttribute(__seq6, "RowTemplate", __arg6);
        __builder.AddAttribute(__seq7, "PagerContent", __arg7);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
