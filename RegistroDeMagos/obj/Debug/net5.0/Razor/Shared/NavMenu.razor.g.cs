#pragma checksum "/Users/codex/Projects/ApiMagos/RegistroDeMagos/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4457fc1128eaf5a1244e4e59bfab438c5d8f6240"
// <auto-generated/>
#pragma warning disable 1591
namespace RegistroDeMagos.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/codex/Projects/ApiMagos/RegistroDeMagos/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/codex/Projects/ApiMagos/RegistroDeMagos/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/codex/Projects/ApiMagos/RegistroDeMagos/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/codex/Projects/ApiMagos/RegistroDeMagos/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/codex/Projects/ApiMagos/RegistroDeMagos/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/codex/Projects/ApiMagos/RegistroDeMagos/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/codex/Projects/ApiMagos/RegistroDeMagos/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/codex/Projects/ApiMagos/RegistroDeMagos/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/codex/Projects/ApiMagos/RegistroDeMagos/_Imports.razor"
using RegistroDeMagos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/codex/Projects/ApiMagos/RegistroDeMagos/_Imports.razor"
using RegistroDeMagos.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-19jcrt4pd5");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-19jcrt4pd5>RegistroDeMagos</a>\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "/Users/codex/Projects/ApiMagos/RegistroDeMagos/Shared/NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-19jcrt4pd5");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-19jcrt4pd5></span>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "/Users/codex/Projects/ApiMagos/RegistroDeMagos/Shared/NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
