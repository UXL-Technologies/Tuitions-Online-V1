#pragma checksum "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c12b03c45af5c73e01718c851d08978e226ad766"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TuitionsOnline.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using TuitionsOnline.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using TuitionsOnline.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\Pages\FetchData.razor"
using TuitionsOnline.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
