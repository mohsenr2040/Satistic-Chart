#pragma checksum "D:\Projects\Office\Chart\Chart_in_Core\Chart_in_Core\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea65dbc429b7c44c278528dda85b264a436aafb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea65dbc429b7c44c278528dda85b264a436aafb2", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88de316f60de9071d03dabcb51b94601bdf06e34", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

    <!--Flowchart---->
    <div id=""wrapper"" class=""flowchart_body"" style=""overflow-x:scroll"">
        <span style=""background-color: green;"" class=""flowcahrt_label"">ارائه اظهارنامه</span>
        <div class=""branch "">
            <div class=""entry sole"">
                <span style=""background-color: green;"" class=""flowcahrt_label"">درخواست اسناد و مدارک</span>
                <div class=""branch "">


                    <div class=""entry sole"">
                        <span style=""background-color: green;"" class=""flowcahrt_label"">صدور برگ تشخیص</span>
                        <div class=""branch lv1"">
                            <div class=""entry"">
                                <span style=""background-color: green;"" class=""flowcahrt_label"">اعتراض</span>
                                <div class=""branch lv2"">
                                    <div class=""entry"">
                                        <span class=""flowcahrt_label"">Entry-1-1</span>
                                       ");
            WriteLiteral(@" <div class=""branch lv3"">
                                            <div class=""entry sole"">
                                                <span class=""flowcahrt_label"">Entry-1-1-1</span>

                                                <div class=""branch "">
                                                    <div class=""entry sole"">
                                                        <span class=""flowcahrt_label"">Entry-1-1-1-1</span>

                                                        <div class=""branch"">
                                                            <div class=""entry sole"">
                                                                <span class=""flowcahrt_label"">Entry-1-1-1-1-1</span>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>


                                  ");
            WriteLiteral(@"          </div>
                                        </div>
                                    </div>
                                    <div class=""entry"">
                                        <span class=""flowcahrt_label"">Entry-1-2</span>
                                        <div class=""branch lv3"">
                                            <div class=""entry sole""><span class=""flowcahrt_label"">Entry-1-2-1</span></div>
                                        </div>
                                    </div>
                                    <div class=""entry"">
                                        <span class=""flowcahrt_label"">Entry-1-3</span>
                                        <div class=""branch lv3"">
                                            <div class=""entry sole""><span class=""flowcahrt_label"">Entry-1-3-1</span></div>
                                        </div>
                                    </div>
                                </div>
                    ");
            WriteLiteral(@"        </div>
                            <div class=""entry"">
                                <span style=""background-color: gray;"" id=""Tamkin"" class=""flowcahrt_label"">تمکین</span>
                                <div class=""branch lv3"">
                                    <div class=""entry sole""><span style=""background-color: gray;"" class=""flowcahrt_label"">صدور برگ قطعی</span></div>
                                </div>
                            </div>
                        </div>



                    </div>
                </div>
            </div>
        </div>

    </div>

");
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
