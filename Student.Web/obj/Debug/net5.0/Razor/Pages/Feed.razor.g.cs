#pragma checksum "/Users/matheusmoraes/Documents/repos/Web-Pos/Student.Web/Pages/Feed.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65c933bba807ad5b2f4115a03ff134d995f19ed5"
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
#line 1 "/Users/matheusmoraes/Documents/repos/Web-Pos/Student.Web/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/matheusmoraes/Documents/repos/Web-Pos/Student.Web/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/matheusmoraes/Documents/repos/Web-Pos/Student.Web/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/matheusmoraes/Documents/repos/Web-Pos/Student.Web/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/matheusmoraes/Documents/repos/Web-Pos/Student.Web/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/matheusmoraes/Documents/repos/Web-Pos/Student.Web/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/matheusmoraes/Documents/repos/Web-Pos/Student.Web/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/matheusmoraes/Documents/repos/Web-Pos/Student.Web/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/matheusmoraes/Documents/repos/Web-Pos/Student.Web/_Imports.razor"
using Student.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/matheusmoraes/Documents/repos/Web-Pos/Student.Web/_Imports.razor"
using Student.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/matheusmoraes/Documents/repos/Web-Pos/Student.Web/Pages/Feed.razor"
using Student.Web.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/matheusmoraes/Documents/repos/Web-Pos/Student.Web/Pages/Feed.razor"
using Student.Web.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/matheusmoraes/Documents/repos/Web-Pos/Student.Web/Pages/Feed.razor"
using Student.Web.Service;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/feed")]
    public partial class Feed : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Projetos</h1>");
#nullable restore
#line 10 "/Users/matheusmoraes/Documents/repos/Web-Pos/Student.Web/Pages/Feed.razor"
 if (SolicitacaoProjeto == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "/Users/matheusmoraes/Documents/repos/Web-Pos/Student.Web/Pages/Feed.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr style=\"background-color: #38598b; color:white\"><th>Projeto</th>\n                <th>Orçamento</th>\n                <th>Localização</th>\n                <th>Status</th></tr></thead>\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 26 "/Users/matheusmoraes/Documents/repos/Web-Pos/Student.Web/Pages/Feed.razor"
             foreach (var solicitacaoProjeto in SolicitacaoProjeto)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
#nullable restore
#line 29 "/Users/matheusmoraes/Documents/repos/Web-Pos/Student.Web/Pages/Feed.razor"
__builder.AddContent(8, solicitacaoProjeto.Titulo);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n                    ");
            __builder.OpenElement(10, "td");
#nullable restore
#line 30 "/Users/matheusmoraes/Documents/repos/Web-Pos/Student.Web/Pages/Feed.razor"
__builder.AddContent(11, solicitacaoProjeto.Orçamento);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n                    ");
            __builder.OpenElement(13, "td");
#nullable restore
#line 31 "/Users/matheusmoraes/Documents/repos/Web-Pos/Student.Web/Pages/Feed.razor"
__builder.AddContent(14, solicitacaoProjeto.Local);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n                    ");
            __builder.AddMarkupContent(16, "<td><button type=\"submit\" class=\"btn btn-primary\">Abrir</button></td>");
            __builder.CloseElement();
#nullable restore
#line 35 "/Users/matheusmoraes/Documents/repos/Web-Pos/Student.Web/Pages/Feed.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "/Users/matheusmoraes/Documents/repos/Web-Pos/Student.Web/Pages/Feed.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "/Users/matheusmoraes/Documents/repos/Web-Pos/Student.Web/Pages/Feed.razor"
       
    private WeatherForecast[] forecasts;
    private IEnumerable<SolicitacaoProjeto> SolicitacaoProjeto;

    protected override async Task OnInitializedAsync()
    {
        SolicitacaoProjeto = await SolicitacaoProjectServer.GetAll();
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SolicitacaoProjectServer SolicitacaoProjectServer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
