#pragma checksum "C:\Users\Maxim\Desktop\АИС\Проект АИС Приложение\AdminsGuide\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d4c5ef7ad87f516726377f6b544168c32b2cf79"
// <auto-generated/>
#pragma warning disable 1591
namespace AdminsGuide.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Maxim\Desktop\АИС\Проект АИС Приложение\AdminsGuide\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Maxim\Desktop\АИС\Проект АИС Приложение\AdminsGuide\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Maxim\Desktop\АИС\Проект АИС Приложение\AdminsGuide\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Maxim\Desktop\АИС\Проект АИС Приложение\AdminsGuide\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Maxim\Desktop\АИС\Проект АИС Приложение\AdminsGuide\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Maxim\Desktop\АИС\Проект АИС Приложение\AdminsGuide\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Maxim\Desktop\АИС\Проект АИС Приложение\AdminsGuide\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Maxim\Desktop\АИС\Проект АИС Приложение\AdminsGuide\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Maxim\Desktop\АИС\Проект АИС Приложение\AdminsGuide\_Imports.razor"
using AdminsGuide;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Maxim\Desktop\АИС\Проект АИС Приложение\AdminsGuide\_Imports.razor"
using AdminsGuide.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Maxim\Desktop\АИС\Проект АИС Приложение\AdminsGuide\_Imports.razor"
using AdminsGuide.Data.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 b-lir4bcmi9z>Справочник администратора</h1>");
#nullable restore
#line 7 "C:\Users\Maxim\Desktop\АИС\Проект АИС Приложение\AdminsGuide\Pages\Index.razor"
 if(!Guides.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<h2 b-lir4bcmi9z>Ответы отсутсвуют</h2>\r\n");
            __builder.AddMarkupContent(2, "<p b-lir4bcmi9z>Добавьте ответы на странице /add</p>");
#nullable restore
#line 10 "C:\Users\Maxim\Desktop\АИС\Проект АИС Приложение\AdminsGuide\Pages\Index.razor"
                                       }
            else { 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddAttribute(5, "b-lir4bcmi9z");
#nullable restore
#line 13 "C:\Users\Maxim\Desktop\АИС\Проект АИС Приложение\AdminsGuide\Pages\Index.razor"
     foreach (var item in Guides)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "a");
            __builder.AddAttribute(7, "class", "a-index");
            __builder.AddAttribute(8, "target", "_blank");
            __builder.AddAttribute(9, "href", "/quest/" + (
#nullable restore
#line 15 "C:\Users\Maxim\Desktop\АИС\Проект АИС Приложение\AdminsGuide\Pages\Index.razor"
                                                          item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "b-lir4bcmi9z");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row border content-index");
            __builder.AddAttribute(13, "b-lir4bcmi9z");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col border-right");
            __builder.AddAttribute(16, "b-lir4bcmi9z");
            __builder.AddContent(17, 
#nullable restore
#line 17 "C:\Users\Maxim\Desktop\АИС\Проект АИС Приложение\AdminsGuide\Pages\Index.razor"
                                                    item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                     ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-10");
            __builder.AddAttribute(21, "b-lir4bcmi9z");
            __builder.AddContent(22, 
#nullable restore
#line 18 "C:\Users\Maxim\Desktop\АИС\Проект АИС Приложение\AdminsGuide\Pages\Index.razor"
                                          item.Question

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\Maxim\Desktop\АИС\Проект АИС Приложение\AdminsGuide\Pages\Index.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\Maxim\Desktop\АИС\Проект АИС Приложение\AdminsGuide\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\Maxim\Desktop\АИС\Проект АИС Приложение\AdminsGuide\Pages\Index.razor"
       

    IEnumerable<Guide> Guides = new List<Guide>();

    protected override void OnInitialized()
    {
        Guides = SqlGuide.GetAllGuides().ToList();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AdminsGuide.Data.Repository.IGuide SqlGuide { get; set; }
    }
}
#pragma warning restore 1591