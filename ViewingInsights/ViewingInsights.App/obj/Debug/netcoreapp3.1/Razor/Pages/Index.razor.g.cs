#pragma checksum "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "325565a7934f13cb0834554133ce392f01ac1614"
// <auto-generated/>
#pragma warning disable 1591
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
#line 12 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-6");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<h3>Single file upload</h3>\r\n        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenUpload>(7);
            __builder.AddAttribute(8, "Url", "upload/single");
            __builder.AddAttribute(9, "Style", "margin-bottom: 20px;");
            __builder.AddAttribute(10, "Progress", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.UploadProgressArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.UploadProgressArgs>(this, 
#nullable restore
#line 6 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\Pages\Index.razor"
                                                                                   (args) => OnProgress(args)

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-md-6");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.AddMarkupContent(16, "<h3>Events</h3>\r\n        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(17);
            __builder.AddAttribute(18, "style", "overflow: auto;height:500px;");
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(20, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenProgressBar>(21);
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 12 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\Pages\Index.razor"
                                       progress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "Unit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\Pages\Index.razor"
                                                        info

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\Pages\Index.razor"
                                                                         progress > 0

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "Style", "margin-bottom: 20px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n");
#nullable restore
#line 13 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\Pages\Index.razor"
             foreach (var e in events.OrderByDescending(i => i.Key))
            {
                

#line default
#line hidden
#nullable disable
                __builder2.AddContent(27, 
#nullable restore
#line 15 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\Pages\Index.razor"
                 e.Value

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(28, "                <br>\r\n");
#nullable restore
#line 17 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(29, "        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\Pages\Index.razor"
       
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
