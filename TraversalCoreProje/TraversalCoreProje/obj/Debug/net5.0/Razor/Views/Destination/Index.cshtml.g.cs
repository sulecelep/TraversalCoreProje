#pragma checksum "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "835693cc248c1d23c2ca83c9c2f9db99d6a87153"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Destination_Index), @"mvc.1.0.view", @"/Views/Destination/Index.cshtml")]
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
#line 1 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"835693cc248c1d23c2ca83c9c2f9db99d6a87153", @"/Views/Destination/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a51958c9bf37a05153a1f850f6d853d08112d134", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Destination_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Traversal-Liberty/assets/js/jquery-3.3.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Traversal-Liberty/assets/js/theme-change.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Traversal-Liberty/assets/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"zxx\">\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "835693cc248c1d23c2ca83c9c2f9db99d6a871535043", async() => {
                WriteLiteral(@"
    <!--header-->

    <!-- //header -->
    <!-- about breadcrumb -->
    <section class=""w3l-about-breadcrumb text-left"">
        <div class=""breadcrumb-bg breadcrumb-bg-about py-sm-5 py-4"">
            <div class=""container"">
                <h2 class=""title"">Rotalar </h2>
                <ul class=""breadcrumbs-custom-path mt-2"">
                    <li><a href=""/Default/Index/"">Ana Sayfa</a></li>
                    <li class=""active""><span class=""fa fa-arrow-right mx-2"" aria-hidden=""true""></span> Rotalarımız </li>
                </ul>
            </div>
        </div>
    </section>
    <!-- //about breadcrumb -->
    <!--  Work gallery section -->
    <section class=""grids-1 py-5"">
        <div class=""grids py-lg-5 py-md-4"">
            <div class=""container"">
                <h3 class=""hny-title mb-5"">Tur Rotalarımız</h3>
                <div class=""row"">
");
#nullable restore
#line 35 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\Index.cshtml"
                     foreach(var item in Model){

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"col-lg-4 col-md-4 col-6\">\r\n                        <div class=\"column\">\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 1251, "\"", 1309, 2);
                WriteAttributeValue("", 1258, "/Destination/DestinationDetails/", 1258, 32, true);
#nullable restore
#line 38 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\Index.cshtml"
WriteAttributeValue("", 1290, item.DestinationID, 1290, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><img");
                BeginWriteAttribute("src", " src=\"", 1315, "\"", 1332, 1);
#nullable restore
#line 38 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\Index.cshtml"
WriteAttributeValue("", 1321, item.Image, 1321, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width:23.5rem; height:18.75rem;\"");
                BeginWriteAttribute("alt", " alt=\"", 1373, "\"", 1379, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid\"></a>\r\n                            <div class=\"info\">\r\n                                    <h4><a");
                BeginWriteAttribute("href", " href=\"", 1495, "\"", 1553, 2);
                WriteAttributeValue("", 1502, "/Destination/DestinationDetails/", 1502, 32, true);
#nullable restore
#line 40 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\Index.cshtml"
WriteAttributeValue("", 1534, item.DestinationID, 1534, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 40 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\Index.cshtml"
                                                                                                 Write(item.City);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></h4>\r\n                                <p>");
#nullable restore
#line 41 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\Index.cshtml"
                              Write(item.DayNight);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n                                <div class=\"dst-btm\">\r\n                                    <h6");
                BeginWriteAttribute("class", " class=\"", 1726, "\"", 1734, 0);
                EndWriteAttribute();
                WriteLiteral(">Başlayan fiyatlarla </h6>\r\n                                    <span>");
#nullable restore
#line 44 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\Index.cshtml"
                                     Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ₺</span>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 49 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n    <!-- Template JavaScript -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "835693cc248c1d23c2ca83c9c2f9db99d6a8715310111", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "835693cc248c1d23c2ca83c9c2f9db99d6a8715311211", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <!--/MENU-JS-->
    <script>
        $(window).on(""scroll"", function () {
            var scroll = $(window).scrollTop();

            if (scroll >= 80) {
                $(""#site-header"").addClass(""nav-fixed"");
            } else {
                $(""#site-header"").removeClass(""nav-fixed"");
            }
        });

        //Main navigation Active Class Add Remove
        $("".navbar-toggler"").on(""click"", function () {
            $(""header"").toggleClass(""active"");
        });
        $(document).on(""ready"", function () {
            if ($(window).width() > 991) {
                $(""header"").removeClass(""active"");
            }
            $(window).on(""resize"", function () {
                if ($(window).width() > 991) {
                    $(""header"").removeClass(""active"");
                }
            });
        });
    </script>
    <!--//MENU-JS-->

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "835693cc248c1d23c2ca83c9c2f9db99d6a8715313244", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Destination>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
