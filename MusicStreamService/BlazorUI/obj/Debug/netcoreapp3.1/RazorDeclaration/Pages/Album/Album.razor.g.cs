#pragma checksum "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicStreamService\BlazorUI\Pages\Album\Album.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3e37bef26e1d0826fdd1e369d0a31a866795433"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicStreamService\BlazorUI\Pages\Album\Album.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicStreamService\BlazorUI\Pages\Album\Album.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicStreamService\BlazorUI\Pages\Album\Album.razor"
using Interfaces.IServices;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Albums/{AlbumId:int}")]
    public partial class Album : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicStreamService\BlazorUI\Pages\Album\Album.razor"
       
    AlbumViewModel album;
    IEnumerable<MusicViewModel> MusicList;
    string ErrorMessage;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            album = await albumService.GetAlbumById(AlbumId);
            MusicList = await musicService.GetAllMusicByAlbumAsync(AlbumId);
        }
        catch (HttpRequestException e)
        {
            ErrorMessage = e.Message;
        }
    }

    [Parameter]
    public int AlbumId { get; set; }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAlbumService albumService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MusicService musicService { get; set; }
    }
}
#pragma warning restore 1591