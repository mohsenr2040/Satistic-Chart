#pragma checksum "D:\Projects\Office\Chart\Chart_in_Core\Chart_in_Core\Views\Shared\Components\GetProducts\GetProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cab9a8cde0d4964c4725927f26f153c26234a079"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_GetProducts_GetProducts), @"mvc.1.0.view", @"/Views/Shared/Components/GetProducts/GetProducts.cshtml")]
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
#line 1 "D:\Projects\Office\Chart\Chart_in_Core\Chart_in_Core\Views\_ViewImports.cshtml"
using Chart_in_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Office\Chart\Chart_in_Core\Chart_in_Core\Views\_ViewImports.cshtml"
using Chart_in_Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cab9a8cde0d4964c4725927f26f153c26234a079", @"/Views/Shared/Components/GetProducts/GetProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88de316f60de9071d03dabcb51b94601bdf06e34", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_GetProducts_GetProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SelleProductsDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projects\Office\Chart\Chart_in_Core\Chart_in_Core\Views\Shared\Components\GetProducts\GetProducts.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\Office\Chart\Chart_in_Core\Chart_in_Core\Views\Shared\Components\GetProducts\GetProducts.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\" role=\"grid\">\r\n        <thead>\r\n            <tr>\r\n                <th>نام کالا</th>\r\n                <th>تعداد</th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 16 "D:\Projects\Office\Chart\Chart_in_Core\Chart_in_Core\Views\Shared\Components\GetProducts\GetProducts.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 19 "D:\Projects\Office\Chart\Chart_in_Core\Chart_in_Core\Views\Shared\Components\GetProducts\GetProducts.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 20 "D:\Projects\Office\Chart\Chart_in_Core\Chart_in_Core\Views\Shared\Components\GetProducts\GetProducts.cshtml"
                   Write(item.inventory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("onclick", " onclick=\"", 496, "\"", 534, 3);
            WriteAttributeValue("", 506, "GetDetail(\'", 506, 11, true);
#nullable restore
#line 21 "D:\Projects\Office\Chart\Chart_in_Core\Chart_in_Core\Views\Shared\Components\GetProducts\GetProducts.cshtml"
WriteAttributeValue("", 517, item.ProductId, 517, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 532, "\')", 532, 2, true);
            EndWriteAttribute();
            WriteLiteral(">جزئیات</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 23 "D:\Projects\Office\Chart\Chart_in_Core\Chart_in_Core\Views\Shared\Components\GetProducts\GetProducts.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 26 "D:\Projects\Office\Chart\Chart_in_Core\Chart_in_Core\Views\Shared\Components\GetProducts\GetProducts.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SelleProductsDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
