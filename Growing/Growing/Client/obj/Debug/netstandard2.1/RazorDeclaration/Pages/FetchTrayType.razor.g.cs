#pragma checksum "/home/anegg0/Dev/Growing/Growing/Growing/Client/Pages/FetchTrayType.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a663b2affde95a08d4de1695071982c46a096076"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Growing.Client.Pages
{
    #line hidden
    using System;
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
#line 2 "/home/anegg0/Dev/Growing/Growing/Growing/Client/Pages/FetchTrayType.razor"
using Growing.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchtraytype")]
    public partial class FetchTrayType : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "/home/anegg0/Dev/Growing/Growing/Growing/Client/Pages/FetchTrayType.razor"
       

    TrayType[] trayTypeList;

    protected override async Task OnInitializedAsync()
    {
        trayTypeList = await Http.GetJsonAsync<TrayType[]>("/api/TrayType/Index");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
