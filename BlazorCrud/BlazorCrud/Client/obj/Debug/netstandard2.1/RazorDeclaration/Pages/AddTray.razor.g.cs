#pragma checksum "C:\Users\gaelb\Documents\Dev\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\Pages\AddTray.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e98c3f3285fb9e215cc5e82762cdb40543340b9"
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
#line 2 "C:\Users\gaelb\Documents\Dev\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\Pages\AddTray.razor"
using BlazorCrud.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addtray")]
    public partial class AddTray : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\gaelb\Documents\Dev\ASPCore.BlazorCrud\BlazorCrud\BlazorCrud\Client\Pages\AddTray.razor"
       
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
#pragma warning restore 1591