#pragma checksum "D:\SoftPlus\Project\Blazor_CRUD_DynamicTable\Blazor.DynamicTable\Blazor.DynamicTable\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3489e02d1e4d27900f403a60a92387a53e8a8eff"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor.DynamicTable.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\SoftPlus\Project\Blazor_CRUD_DynamicTable\Blazor.DynamicTable\Blazor.DynamicTable\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SoftPlus\Project\Blazor_CRUD_DynamicTable\Blazor.DynamicTable\Blazor.DynamicTable\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SoftPlus\Project\Blazor_CRUD_DynamicTable\Blazor.DynamicTable\Blazor.DynamicTable\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SoftPlus\Project\Blazor_CRUD_DynamicTable\Blazor.DynamicTable\Blazor.DynamicTable\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\SoftPlus\Project\Blazor_CRUD_DynamicTable\Blazor.DynamicTable\Blazor.DynamicTable\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\SoftPlus\Project\Blazor_CRUD_DynamicTable\Blazor.DynamicTable\Blazor.DynamicTable\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\SoftPlus\Project\Blazor_CRUD_DynamicTable\Blazor.DynamicTable\Blazor.DynamicTable\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\SoftPlus\Project\Blazor_CRUD_DynamicTable\Blazor.DynamicTable\Blazor.DynamicTable\_Imports.razor"
using Blazor.DynamicTable;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\SoftPlus\Project\Blazor_CRUD_DynamicTable\Blazor.DynamicTable\Blazor.DynamicTable\_Imports.razor"
using Blazor.DynamicTable.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\SoftPlus\Project\Blazor_CRUD_DynamicTable\Blazor.DynamicTable\Blazor.DynamicTable\Shared\NavMenu.razor"
using Blazor.DynamicTable.Servives;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "D:\SoftPlus\Project\Blazor_CRUD_DynamicTable\Blazor.DynamicTable\Blazor.DynamicTable\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDynamicTableService IQueryDynamicTable { get; set; }
    }
}
#pragma warning restore 1591