#pragma checksum "/home/anegg0/Dev/Growing/Growing/Growing/Client/Pages/AddTray.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71004f4cfc8cafc7ceb560e7789bec2bdbf54781"
// <auto-generated/>
#pragma warning disable 1591
namespace Growing.Client.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/anegg0/Dev/Growing/Growing/Growing/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/anegg0/Dev/Growing/Growing/Growing/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/anegg0/Dev/Growing/Growing/Growing/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/anegg0/Dev/Growing/Growing/Growing/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/anegg0/Dev/Growing/Growing/Growing/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/anegg0/Dev/Growing/Growing/Growing/Client/_Imports.razor"
using Growing.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/anegg0/Dev/Growing/Growing/Growing/Client/_Imports.razor"
using Growing.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/anegg0/Dev/Growing/Growing/Growing/Client/Pages/AddTray.razor"
using Growing.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/anegg0/Dev/Growing/Growing/Growing/Client/Pages/AddTray.razor"
using System;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addtray")]
    public partial class AddTray : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Create Tray</h1>\n<hr>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "/home/anegg0/Dev/Growing/Growing/Growing/Client/Pages/AddTray.razor"
                  tray

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "/home/anegg0/Dev/Growing/Growing/Growing/Client/Pages/AddTray.razor"
                                       CreateTray

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group row");
                __builder2.AddMarkupContent(10, "\n        ");
                __builder2.AddMarkupContent(11, "<label class=\"control-label col-md-12\">Name</label>\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-md-4");
                __builder2.AddMarkupContent(14, "\n            ");
                __builder2.OpenElement(15, "input");
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "/home/anegg0/Dev/Growing/Growing/Growing/Client/Pages/AddTray.razor"
                                               tray.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tray.Name = __value, tray.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n        ");
                __Blazor.Growing.Client.Pages.AddTray.TypeInference.CreateValidationMessage_0(__builder2, 21, 22, 
#nullable restore
#line 17 "/home/anegg0/Dev/Growing/Growing/Growing/Client/Pages/AddTray.razor"
                                  () => tray.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(23, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\n    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group row");
                __builder2.AddMarkupContent(27, "\n        ");
                __builder2.AddMarkupContent(28, "<label class=\"control-label col-md-12\">Gender</label>\n        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "col-md-4");
                __builder2.AddMarkupContent(31, "\n            ");
                __builder2.OpenElement(32, "select");
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "/home/anegg0/Dev/Growing/Growing/Growing/Client/Pages/AddTray.razor"
                                                tray.Gender

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tray.Gender = __value, tray.Gender));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(36, "\n                ");
                __builder2.OpenElement(37, "option");
                __builder2.AddAttribute(38, "value", true);
                __builder2.AddContent(39, "-- Select Gender --");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\n                ");
                __builder2.OpenElement(41, "option");
                __builder2.AddAttribute(42, "value", "Male");
                __builder2.AddContent(43, "Male");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\n                ");
                __builder2.OpenElement(45, "option");
                __builder2.AddAttribute(46, "value", "Female");
                __builder2.AddContent(47, "Female");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\n        ");
                __Blazor.Growing.Client.Pages.AddTray.TypeInference.CreateValidationMessage_1(__builder2, 51, 52, 
#nullable restore
#line 28 "/home/anegg0/Dev/Growing/Growing/Growing/Client/Pages/AddTray.razor"
                                  () => tray.Gender

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(53, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\n    ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group row");
                __builder2.AddMarkupContent(57, "\n        ");
                __builder2.AddMarkupContent(58, "<label class=\"control-label col-md-12\">Department</label>\n        ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "col-md-4");
                __builder2.AddMarkupContent(61, "\n            ");
                __builder2.OpenElement(62, "input");
                __builder2.AddAttribute(63, "class", "form-control");
                __builder2.AddAttribute(64, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "/home/anegg0/Dev/Growing/Growing/Growing/Client/Pages/AddTray.razor"
                                               tray.Department

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tray.Department = __value, tray.Department));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\n        ");
                __Blazor.Growing.Client.Pages.AddTray.TypeInference.CreateValidationMessage_2(__builder2, 68, 69, 
#nullable restore
#line 35 "/home/anegg0/Dev/Growing/Growing/Growing/Client/Pages/AddTray.razor"
                                  () => tray.Department

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(70, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\n    ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "form-group row");
                __builder2.AddMarkupContent(74, "\n        ");
                __builder2.AddMarkupContent(75, "<label class=\"control-label col-md-12\">City</label>\n        ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "col-md-4");
                __builder2.AddMarkupContent(78, "\n            ");
                __builder2.OpenElement(79, "input");
                __builder2.AddAttribute(80, "class", "form-control");
                __builder2.AddAttribute(81, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "/home/anegg0/Dev/Growing/Growing/Growing/Client/Pages/AddTray.razor"
                                               tray.City

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(82, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tray.City = __value, tray.City));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\n        ");
                __Blazor.Growing.Client.Pages.AddTray.TypeInference.CreateValidationMessage_3(__builder2, 85, 86, 
#nullable restore
#line 42 "/home/anegg0/Dev/Growing/Growing/Growing/Client/Pages/AddTray.razor"
                                  () => tray.City

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(87, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\n    ");
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "form-group row");
                __builder2.AddMarkupContent(91, "\n        ");
                __builder2.AddMarkupContent(92, "<label class=\"control-label col-md-12\">Sowing Date</label>\n        ");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "col-md-4");
                __builder2.AddMarkupContent(95, "\n            ");
                __builder2.OpenElement(96, "input");
                __builder2.AddAttribute(97, "class", "form-control");
                __builder2.AddAttribute(98, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "/home/anegg0/Dev/Growing/Growing/Growing/Client/Pages/AddTray.razor"
                                               tray.SowingDate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(99, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tray.SowingDate = __value, tray.SowingDate));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\n        ");
                __Blazor.Growing.Client.Pages.AddTray.TypeInference.CreateValidationMessage_4(__builder2, 102, 103, 
#nullable restore
#line 49 "/home/anegg0/Dev/Growing/Growing/Growing/Client/Pages/AddTray.razor"
                                  () => tray.SowingDate

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(104, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\n    ");
                __builder2.OpenElement(106, "div");
                __builder2.AddAttribute(107, "class", "form-group");
                __builder2.AddMarkupContent(108, "\n        ");
                __builder2.AddMarkupContent(109, "<button type=\"submit\" class=\"btn btn-primary\">Save</button>\n        ");
                __builder2.OpenElement(110, "button");
                __builder2.AddAttribute(111, "class", "btn btn-light");
                __builder2.AddAttribute(112, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "/home/anegg0/Dev/Growing/Growing/Growing/Client/Pages/AddTray.razor"
                                                Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(113, "Cancel");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "/home/anegg0/Dev/Growing/Growing/Growing/Client/Pages/AddTray.razor"
       
    Tray tray = new Tray();

    protected async Task CreateTray()
    {
        await Http.SendJsonAsync(HttpMethod.Post, "/api/Tray/Create", tray);
        urlNavigationManager.NavigateTo("/fetchtray");
    }

    void Cancel()
    {
        urlNavigationManager.NavigateTo("/fetchtray");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager urlNavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.Growing.Client.Pages.AddTray
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
