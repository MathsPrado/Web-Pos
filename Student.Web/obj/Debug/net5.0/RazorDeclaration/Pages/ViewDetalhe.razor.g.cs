// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "/Users/matheusmoraes/Documents/repos/Web-Pos/Student.Web/Pages/ViewDetalhe.razor"
using Student.Web.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/matheusmoraes/Documents/repos/Web-Pos/Student.Web/Pages/ViewDetalhe.razor"
using Student.Web.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/RequestDetalhe/{Id:int}")]
    public partial class ViewDetalhe : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 109 "/Users/matheusmoraes/Documents/repos/Web-Pos/Student.Web/Pages/ViewDetalhe.razor"
       

    [Parameter]
    public int Id { get; set; }

    public string TimeEndProject { get; set; }

    protected override void OnInitialized()
    {
        string dataInit = "2023-03-12T12:35:16.379";

        string dataEnd = "2023-03-12T12:35:16.379";

        TimeSpan date = Convert.ToDateTime(dataEnd) - Convert.ToDateTime(dataInit);

        int totalDias = date.Days;
        TimeEndProject = String.Format("{0} dias, {1} horas",
                         date.Hours, date.Days);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591