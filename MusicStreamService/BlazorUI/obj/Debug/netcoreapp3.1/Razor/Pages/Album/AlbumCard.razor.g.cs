#pragma checksum "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicStreamService\BlazorUI\Pages\Album\AlbumCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db77aa8784dc026c96ebae307c634a27f1965cca"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorUI.Pages.Album
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicStreamService\BlazorUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicStreamService\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicStreamService\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicStreamService\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicStreamService\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicStreamService\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicStreamService\BlazorUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicStreamService\BlazorUI\_Imports.razor"
using BlazorUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicStreamService\BlazorUI\_Imports.razor"
using BlazorUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicStreamService\BlazorUI\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicStreamService\BlazorUI\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicStreamService\BlazorUI\Pages\Album\AlbumCard.razor"
using Models;

#line default
#line hidden
#nullable disable
    public partial class AlbumCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link rel=\"stylesheet\" type=\"text/css\" href=\"PagesCss/albumStyles/albumCardStyle.css\">\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card albumCard");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "img");
            __builder.AddAttribute(5, "src", 
#nullable restore
#line 6 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicStreamService\BlazorUI\Pages\Album\AlbumCard.razor"
               album.photoPath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicStreamService\BlazorUI\Pages\Album\AlbumCard.razor"
                                          onclick

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "demo-mat-card-content");
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "authorinfo album-info");
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "span");
            __builder.AddContent(15, " ");
            __builder.AddContent(16, 
#nullable restore
#line 9 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicStreamService\BlazorUI\Pages\Album\AlbumCard.razor"
                    album.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "album-info");
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "span");
            __builder.AddContent(22, 
#nullable restore
#line 11 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicStreamService\BlazorUI\Pages\Album\AlbumCard.razor"
                       album.author

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.AddMarkupContent(24, "<span> • </span>\r\n                ");
            __builder.OpenElement(25, "span");
            __builder.AddContent(26, 
#nullable restore
#line 13 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicStreamService\BlazorUI\Pages\Album\AlbumCard.razor"
                       album.year

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicStreamService\BlazorUI\Pages\Album\AlbumCard.razor"
       
    [Parameter]
    public AlbumViewModel album { get; set; }

    [Parameter]
    public EventCallback<MouseEventArgs> onclick { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
