#pragma checksum "C:\Users\gaelb\Documents\Dev\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\Pages\FetchTray.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "196cd0a6e2de1e18f0dd041c0f12649e812e25fb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorCrud.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gaelb\Documents\Dev\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gaelb\Documents\Dev\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gaelb\Documents\Dev\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gaelb\Documents\Dev\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gaelb\Documents\Dev\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gaelb\Documents\Dev\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using BlazorCrud.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gaelb\Documents\Dev\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\_Imports.razor"
using BlazorCrud.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gaelb\Documents\Dev\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\Pages\FetchTray.razor"
using BlazorCrud.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchtray")]
    public partial class FetchTray : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\gaelb\Documents\Dev\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\Pages\FetchTray.razor"
       

    Tray[] trayList;

    protected override async Task OnInitializedAsync()
    {
        trayList = await Http.GetJsonAsync<Tray[]>("/api/Tray/Index");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591