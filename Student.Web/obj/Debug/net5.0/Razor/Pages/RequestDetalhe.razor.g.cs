#pragma checksum "C:\Users\mathe\Pictures\.net\Projects\Student.Web\Student.Web\Pages\RequestDetalhe.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47874d6ebce6d0bb9afe972e0c1dbf7cc2da389f"
// <auto-generated/>
#pragma warning disable 1591
namespace Student.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mathe\Pictures\.net\Projects\Student.Web\Student.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mathe\Pictures\.net\Projects\Student.Web\Student.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mathe\Pictures\.net\Projects\Student.Web\Student.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mathe\Pictures\.net\Projects\Student.Web\Student.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mathe\Pictures\.net\Projects\Student.Web\Student.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mathe\Pictures\.net\Projects\Student.Web\Student.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mathe\Pictures\.net\Projects\Student.Web\Student.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mathe\Pictures\.net\Projects\Student.Web\Student.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mathe\Pictures\.net\Projects\Student.Web\Student.Web\_Imports.razor"
using Student.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mathe\Pictures\.net\Projects\Student.Web\Student.Web\_Imports.razor"
using Student.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mathe\Pictures\.net\Projects\Student.Web\Student.Web\Pages\RequestDetalhe.razor"
using Student.Web.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mathe\Pictures\.net\Projects\Student.Web\Student.Web\Pages\RequestDetalhe.razor"
using Student.Web.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RequestDetalhe")]
    public partial class RequestDetalhe : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "C:\Users\mathe\Pictures\.net\Projects\Student.Web\Student.Web\Pages\RequestDetalhe.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading...</em></p>");
#nullable restore
#line 10 "C:\Users\mathe\Pictures\.net\Projects\Student.Web\Student.Web\Pages\RequestDetalhe.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div class=\"container\"><h2>Detalhes do projeto</h2>\r\n        <div class=\"panel-group\"></div></div>\r\n    ");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr style=\"background-color: #38598b; color:white\"><th>Projeto</th>\r\n                <th>Valor</th>\r\n                <th>Orçamento</th>\r\n                <th>Localização</th>\r\n                <th>Status</th></tr></thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 29 "C:\Users\mathe\Pictures\.net\Projects\Student.Web\Student.Web\Pages\RequestDetalhe.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
#nullable restore
#line 32 "C:\Users\mathe\Pictures\.net\Projects\Student.Web\Student.Web\Pages\RequestDetalhe.razor"
__builder.AddContent(8, forecast.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "td");
#nullable restore
#line 33 "C:\Users\mathe\Pictures\.net\Projects\Student.Web\Student.Web\Pages\RequestDetalhe.razor"
__builder.AddContent(11, forecast.TemperatureC);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
#nullable restore
#line 34 "C:\Users\mathe\Pictures\.net\Projects\Student.Web\Student.Web\Pages\RequestDetalhe.razor"
__builder.AddContent(14, forecast.TemperatureF);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
#nullable restore
#line 35 "C:\Users\mathe\Pictures\.net\Projects\Student.Web\Student.Web\Pages\RequestDetalhe.razor"
__builder.AddContent(17, forecast.Summary);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.AddMarkupContent(19, "<td><button type=\"submit\" class=\"btn btn-primary\">Abrir</button></td>");
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\mathe\Pictures\.net\Projects\Student.Web\Student.Web\Pages\RequestDetalhe.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Users\mathe\Pictures\.net\Projects\Student.Web\Student.Web\Pages\RequestDetalhe.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\mathe\Pictures\.net\Projects\Student.Web\Student.Web\Pages\RequestDetalhe.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }
        

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591