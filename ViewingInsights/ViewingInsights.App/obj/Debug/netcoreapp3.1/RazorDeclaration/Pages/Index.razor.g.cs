#pragma checksum "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5365486028027fa0e334b12faa9203bcfed111c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ViewingInsights.App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\_Imports.razor"
using ViewingInsights.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\_Imports.razor"
using ViewingInsights.App.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\Pages\Index.razor"
using ViewingInsights.App.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\Pages\Index.razor"
       
    RadzenUpload upload;

    int progress;
    string info;
    Dictionary<DateTime, string> events = new Dictionary<DateTime, string>();

    void OnProgress(UploadProgressArgs args)
    {
        this.info = $"{args.Loaded} of {args.Total} bytes.";
        this.progress = args.Progress;

        if (args.Progress == 100)
        {
            events.Clear();
            foreach (var file in args.Files)
            {
                events.Add(DateTime.Now, $"Uploaded: {file.Name} / {file.Size} bytes");
            }
        }
    }

    void Completed(UploadCompleteEventArgs args)
    {
        events.Add(DateTime.Now, $"Server response: {args.RawResponse}");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
