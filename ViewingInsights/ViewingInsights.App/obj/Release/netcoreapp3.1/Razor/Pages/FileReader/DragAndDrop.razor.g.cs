#pragma checksum "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\Pages\FileReader\DragAndDrop.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce3072b363df99f63f4fc9fa1ecf62098be96c18"
// <auto-generated/>
#pragma warning disable 1591
namespace ViewingInsights.App.Pages.FileReader
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
#nullable restore
#line 13 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dragAndDrop")]
    public partial class DragAndDrop : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Drag/drop file viewer</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Shows how you can present a custom UI instead of the native file input.</p>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "drag-drop-zone");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<BlazorInputFile.InputFile>(5);
            __builder.AddAttribute(6, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 8 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\Pages\FileReader\DragAndDrop.razor"
                         ViewFile

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.AddContent(8, 
#nullable restore
#line 9 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\Pages\FileReader\DragAndDrop.razor"
     status

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
#nullable restore
#line 12 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\Pages\FileReader\DragAndDrop.razor"
 if (fileName != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "    ");
            __builder.OpenElement(12, "h3");
            __builder.AddContent(13, 
#nullable restore
#line 14 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\Pages\FileReader\DragAndDrop.razor"
         fileName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "pre");
            __builder.AddContent(16, 
#nullable restore
#line 15 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\Pages\FileReader\DragAndDrop.razor"
          fileTextContents

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 16 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\Pages\FileReader\DragAndDrop.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\nunor\Documents\netflixDash\ViewingInsights\ViewingInsights.App\Pages\FileReader\DragAndDrop.razor"
       
    const string DefaultStatus = "Drop a text file here to view it, or click to choose a file";
    const int MaxFileSize = 5 * 1024 * 1024; // 5MB
    string status = DefaultStatus;

    string fileName;
    string fileTextContents;

    async Task ViewFile(IFileListEntry[] files)
    {
        var file = files.FirstOrDefault();
        if (file == null)
        {
            return;
        }
        else if (file.Size > MaxFileSize)
        {
            status = $"That's too big. Max size: {MaxFileSize} bytes.";
        }
        else
        {
            status = "Loading...";

            using (var reader = new System.IO.StreamReader(file.Data))
            {
                fileTextContents = await reader.ReadToEndAsync();
                fileName = file.Name;
            }

            status = DefaultStatus;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
