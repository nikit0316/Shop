#pragma checksum "C:\Users\tresk\source\repos\Shop\Shop\Views\Cars\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef7695ee236ce7ed450ac460cf930442829636fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_List), @"mvc.1.0.view", @"/Views/Cars/List.cshtml")]
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
#line 1 "C:\Users\tresk\source\repos\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef7695ee236ce7ed450ac460cf930442829636fc", @"/Views/Cars/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8698b1ec29562463bc33480ac52eac0346944c13", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Все автомобили</h1>\r\n<h3>");
#nullable restore
#line 2 "C:\Users\tresk\source\repos\Shop\Shop\Views\Cars\List.cshtml"
Write(Model.currCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 3 "C:\Users\tresk\source\repos\Shop\Shop\Views\Cars\List.cshtml"
       
	foreach(var car in Model.allCars)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div>\r\n\t\t\t<h2>Модель: ");
#nullable restore
#line 7 "C:\Users\tresk\source\repos\Shop\Shop\Views\Cars\List.cshtml"
                   Write(car.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\t\t\t<p>Цена: ");
#nullable restore
#line 8 "C:\Users\tresk\source\repos\Shop\Shop\Views\Cars\List.cshtml"
                Write(car.price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t</div>\r\n");
#nullable restore
#line 10 "C:\Users\tresk\source\repos\Shop\Shop\Views\Cars\List.cshtml"
		}
	

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591