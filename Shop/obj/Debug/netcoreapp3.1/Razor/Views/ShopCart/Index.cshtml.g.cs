#pragma checksum "C:\Users\tresk\Desktop\Shop\Shop\Views\ShopCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f76bc52524cef57098b4b4695b79c491f62dd1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShopCart_Index), @"mvc.1.0.view", @"/Views/ShopCart/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\tresk\Desktop\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tresk\Desktop\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f76bc52524cef57098b4b4695b79c491f62dd1b", @"/Views/ShopCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e2f810e333d19a429815c58fa3b8bb12eb4b8c1", @"/Views/_ViewImports.cshtml")]
    public class Views_ShopCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopCartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container\">\r\n");
#nullable restore
#line 3 "C:\Users\tresk\Desktop\Shop\Shop\Views\ShopCart\Index.cshtml"
     foreach(var el in Model.shopCart.listShopItems)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"alert alert-warning mt-3\">\r\n\t\t<b>Автомобиль:</b> ");
#nullable restore
#line 6 "C:\Users\tresk\Desktop\Shop\Shop\Views\ShopCart\Index.cshtml"
                      Write(el.car.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\t\t<b>Цена:</b> ");
#nullable restore
#line 7 "C:\Users\tresk\Desktop\Shop\Shop\Views\ShopCart\Index.cshtml"
                Write(el.car.price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</div> \r\n");
#nullable restore
#line 9 "C:\Users\tresk\Desktop\Shop\Shop\Views\ShopCart\Index.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<br />\r\n\t<div class=\"btn btn-danger\" asp-controller=\"Order\">Оплатить</div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
