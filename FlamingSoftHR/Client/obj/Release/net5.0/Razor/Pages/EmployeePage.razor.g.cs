#pragma checksum "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/EmployeePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c949e15ea38792e67852b0a26cf410a2a4b9bed"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/employees")]
    public partial class EmployeePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudGrid>(0);
            __builder.AddAttribute(1, "Justify", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Justify>(
#nullable restore
#line 3 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/EmployeePage.razor"
                  Justify.Center

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudItem>(3);
                __builder2.AddAttribute(4, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 4 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/EmployeePage.razor"
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
#line 6 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/EmployeePage.razor"
                          Justify.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudItem>(10);
                        __builder4.AddAttribute(11, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 7 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/EmployeePage.razor"
                         12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudPaper>(13);
                            __builder5.AddAttribute(14, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/EmployeePage.razor"
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
#line 12 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/EmployeePage.razor"
                                     12

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.OpenComponent<MudBlazor.MudText>(22);
                                        __builder8.AddAttribute(23, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 13 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/EmployeePage.razor"
                                           Typo.h4

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.AddContent(25, " Employees ");
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
#line 16 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/EmployeePage.razor"
                                     12

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __Blazor.FlamingSoftHR.Client.Pages.EmployeePage.TypeInference.CreateMudTable_0(__builder8, 30, 31, 
#nullable restore
#line 18 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/EmployeePage.razor"
                                                    new Func<TableState, Task<TableData<Employee>>>(ServerPaging)

#line default
#line hidden
#nullable disable
                                        , 32, 
#nullable restore
#line 18 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/EmployeePage.razor"
                                                                                                                           true

#line default
#line hidden
#nullable disable
                                        , 33, 
#nullable restore
#line 18 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/EmployeePage.razor"
                                                                                                                                             Breakpoint.Sm

#line default
#line hidden
#nullable disable
                                        , 34, 
#nullable restore
#line 18 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/EmployeePage.razor"
                                                                                                                                                                      loading

#line default
#line hidden
#nullable disable
                                        , 35, 
#nullable restore
#line 18 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/EmployeePage.razor"
                                                                                                                                                                                                     Color.Error

#line default
#line hidden
#nullable disable
                                        , 36, (__builder9) => {
                                            __builder9.OpenComponent<MudBlazor.MudTh>(37);
                                            __builder9.AddAttribute(38, "Class", "red-text text-darken-4");
                                            __builder9.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder10) => {
                                                __builder10.AddContent(40, "Employee Id");
                                            }
                                            ));
                                            __builder9.CloseComponent();
                                            __builder9.AddMarkupContent(41, "\n                                    ");
                                            __builder9.OpenComponent<MudBlazor.MudTh>(42);
                                            __builder9.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder10) => {
                                                __builder10.AddContent(44, "Name");
                                            }
                                            ));
                                            __builder9.CloseComponent();
                                            __builder9.AddMarkupContent(45, "\n                                    ");
                                            __builder9.OpenComponent<MudBlazor.MudTh>(46);
                                            __builder9.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder10) => {
                                                __builder10.AddContent(48, "Department");
                                            }
                                            ));
                                            __builder9.CloseComponent();
                                            __builder9.AddMarkupContent(49, "\n                                    ");
                                            __builder9.OpenComponent<MudBlazor.MudTh>(50);
                                            __builder9.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder10) => {
                                                __builder10.AddContent(52, "Salary");
                                            }
                                            ));
                                            __builder9.CloseComponent();
                                            __builder9.AddMarkupContent(53, "\n                                    ");
                                            __builder9.OpenComponent<MudBlazor.MudTh>(54);
                                            __builder9.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder10) => {
                                                __builder10.AddContent(56, "Actions");
                                            }
                                            ));
                                            __builder9.CloseComponent();
                                        }
                                        , 57, (context) => (__builder9) => {
                                            __builder9.OpenComponent<MudBlazor.MudTd>(58);
                                            __builder9.AddAttribute(59, "DataLabel", "Employee Id");
                                            __builder9.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder10) => {
                                                __builder10.AddContent(61, 
#nullable restore
#line 29 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/EmployeePage.razor"
                                                                     context.Id

#line default
#line hidden
#nullable disable
                                                );
                                            }
                                            ));
                                            __builder9.CloseComponent();
                                            __builder9.AddMarkupContent(62, "\n                                    ");
                                            __builder9.OpenComponent<MudBlazor.MudTd>(63);
                                            __builder9.AddAttribute(64, "DataLabel", "Name");
                                            __builder9.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder10) => {
                                                __builder10.AddContent(66, 
#nullable restore
#line 30 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/EmployeePage.razor"
                                                             context.FirstName

#line default
#line hidden
#nullable disable
                                                );
                                                __builder10.AddContent(67, " ");
                                                __builder10.AddContent(68, 
#nullable restore
#line 30 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/EmployeePage.razor"
                                                                                context.LastName

#line default
#line hidden
#nullable disable
                                                );
                                            }
                                            ));
                                            __builder9.CloseComponent();
                                            __builder9.AddMarkupContent(69, "\n                                    ");
                                            __builder9.OpenComponent<MudBlazor.MudTd>(70);
                                            __builder9.AddAttribute(71, "DataLabel", "Department");
                                            __builder9.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder10) => {
                                                __builder10.AddContent(73, 
#nullable restore
#line 31 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/EmployeePage.razor"
                                                                   context.Job.Department.Name

#line default
#line hidden
#nullable disable
                                                );
                                            }
                                            ));
                                            __builder9.CloseComponent();
                                            __builder9.AddMarkupContent(74, "\n                                    ");
                                            __builder9.OpenComponent<MudBlazor.MudTd>(75);
                                            __builder9.AddAttribute(76, "DataLabel", "Salary");
                                            __builder9.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder10) => {
                                                __builder10.AddContent(78, " $ ");
                                                __builder10.AddContent(79, 
#nullable restore
#line 32 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/EmployeePage.razor"
                                                                   String.Format("{0:n}",context.Salary)

#line default
#line hidden
#nullable disable
                                                );
                                            }
                                            ));
                                            __builder9.CloseComponent();
                                            __builder9.AddMarkupContent(80, "\n                                    ");
                                            __builder9.OpenComponent<MudBlazor.MudTd>(81);
                                            __builder9.AddAttribute(82, "DataLabel", "Actions");
                                            __builder9.AddAttribute(83, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder10) => {
                                                __builder10.AddContent(84, "0");
                                            }
                                            ));
                                            __builder9.CloseComponent();
                                        }
                                        , 85, (__builder9) => {
                                            __builder9.OpenComponent<MudBlazor.MudTablePager>(86);
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
#line 53 "/Users/cnuila/Proyectos/CodingChallengeFlamingSoft1/FlamingSoftHR/Client/Pages/EmployeePage.razor"
       

    [Inject]
    public IDialogService DialogService { get; set; }

    [Inject]
    public IEmployeeService EmployeeService { get; set; }

    private bool loading = true;

    // skip = current page times the size of it in order to get how many of them we want to skip
    // once skip and take are assigned, it queries with the data provided
    private async Task<TableData<Employee>> ServerPaging(TableState tableState)
    {
        int skip = tableState.Page * tableState.PageSize;
        int take = tableState.PageSize;

        EmployeeDataResult result = await EmployeeService.GetEmployees(skip, take);
        loading = false;

        int totalItems = result.Count;

        return new TableData<Employee>() { TotalItems = totalItems, Items = result.Employees.ToList() };
    }

    private void OpenAddEmployee()
    {
        DialogService.Show<AddUpdateEmployee>("Add Employee");
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.FlamingSoftHR.Client.Pages.EmployeePage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::MudBlazor.TableState, global::System.Threading.Tasks.Task<global::MudBlazor.TableData<T>>> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::MudBlazor.Breakpoint __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::MudBlazor.Color __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment __arg7)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "ServerData", __arg0);
        __builder.AddAttribute(__seq1, "Hover", __arg1);
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