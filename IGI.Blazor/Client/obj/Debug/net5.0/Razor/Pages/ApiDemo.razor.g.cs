#pragma checksum "C:\Users\Ilya\Desktop\IGI-2022\IGI.Blazor\Client\Pages\ApiDemo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3690edb3c832d93783f5fe88d06afa16ee66b51f"
// <auto-generated/>
#pragma warning disable 1591
namespace IGI.Blazor.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ilya\Desktop\IGI-2022\IGI.Blazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ilya\Desktop\IGI-2022\IGI.Blazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ilya\Desktop\IGI-2022\IGI.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ilya\Desktop\IGI-2022\IGI.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ilya\Desktop\IGI-2022\IGI.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ilya\Desktop\IGI-2022\IGI.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ilya\Desktop\IGI-2022\IGI.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ilya\Desktop\IGI-2022\IGI.Blazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ilya\Desktop\IGI-2022\IGI.Blazor\Client\_Imports.razor"
using IGI.Blazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ilya\Desktop\IGI-2022\IGI.Blazor\Client\_Imports.razor"
using IGI.Blazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Ilya\Desktop\IGI-2022\IGI.Blazor\Client\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Ilya\Desktop\IGI-2022\IGI.Blazor\Client\_Imports.razor"
using IGI.Blazor.Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Ilya\Desktop\IGI-2022\IGI.Blazor\Client\Pages\ApiDemo.razor"
using IGI.Blazor.Client.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/apidemo")]
    public partial class ApiDemo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenComponent<IGI.Blazor.Client.Components.PCPartsList>(2);
            __builder.AddAttribute(3, "SelectedObjectChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 6 "C:\Users\Ilya\Desktop\IGI-2022\IGI.Blazor\Client\Pages\ApiDemo.razor"
                                                                 ShowDetails

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "PCParts", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<IGI.Blazor.Client.Models.ListViewModel>>(
#nullable restore
#line 6 "C:\Users\Ilya\Desktop\IGI-2022\IGI.Blazor\Client\Pages\ApiDemo.razor"
                                 PCParts

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "PCPartsChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.IEnumerable<IGI.Blazor.Client.Models.ListViewModel>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.IEnumerable<IGI.Blazor.Client.Models.ListViewModel>>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => PCParts = __value, PCParts))));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\n    ");
            __builder.OpenComponent<IGI.Blazor.Client.Components.PCPartDetails>(7);
            __builder.AddAttribute(8, "PCPart", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<IGI.Blazor.Client.Models.DetailsViewModel>(
#nullable restore
#line 8 "C:\Users\Ilya\Desktop\IGI-2022\IGI.Blazor\Client\Pages\ApiDemo.razor"
                                  SelectedPCPart

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "PCPartChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<IGI.Blazor.Client.Models.DetailsViewModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<IGI.Blazor.Client.Models.DetailsViewModel>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SelectedPCPart = __value, SelectedPCPart))));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\Ilya\Desktop\IGI-2022\IGI.Blazor\Client\Pages\ApiDemo.razor"
       
    [Parameter]
    public IEnumerable<ListViewModel> PCParts { get; set; }

    protected override async Task OnInitializedAsync()
    {
        PCParts = await client.GetFromJsonAsync<IEnumerable<ListViewModel>>("api/PCPartsAPI");
    }

    [Parameter]
    public DetailsViewModel SelectedPCPart { get; set; }

    private async Task ShowDetails(int id)
    {
        SelectedPCPart = await client.GetFromJsonAsync<DetailsViewModel>($"api/PCPartsAPI/{id}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
