#pragma checksum "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_TotalRevenue\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df93364d8c5b2334bcc38f48eaf2328cbf7cc244"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__TotalRevenue_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_TotalRevenue/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df93364d8c5b2334bcc38f48eaf2328cbf7cc244", @"/Views/Shared/Components/_TotalRevenue/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a51958c9bf37a05153a1f850f6d853d08112d134", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__TotalRevenue_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""col-12 col-lg-8 order-2 order-md-3 order-lg-2 mb-4"">
    <div class=""card"">
        <div class=""row row-bordered g-0"">
            <div class=""col-md-8"">
                <h5 class=""card-header m-0 me-2 pb-3"">Toplam Kazanç</h5>
                <div id=""totalRevenueChart"" class=""px-2""></div>
            </div>
            <div class=""col-md-4"">
                <div class=""card-body"">
                    <div class=""text-center"">
                        <div class=""dropdown"">
                            <button class=""btn btn-sm btn-outline-primary dropdown-toggle""
                                    type=""button""
                                    id=""growthReportId""
                                    data-bs-toggle=""dropdown""
                                    aria-haspopup=""true""
                                    aria-expanded=""false"">
                                2022
                            </button>
                            <div class=""dropdown-menu dropdown-");
            WriteLiteral(@"menu-end"" aria-labelledby=""growthReportId"">
                                <a class=""dropdown-item"" href=""javascript:void(0);"">2021</a>
                                <a class=""dropdown-item"" href=""javascript:void(0);"">2020</a>
                                <a class=""dropdown-item"" href=""javascript:void(0);"">2019</a>
                            </div>
                        </div>
                    </div>
                </div>
                <div id=""growthChart""></div>
                <div class=""text-center fw-semibold pt-3 mb-2"">62% Büyüme Oranı</div>

                <div class=""d-flex px-xxl-4 px-lg-2 p-4 gap-xxl-3 gap-lg-1 gap-3 justify-content-between"">
                    <div class=""d-flex"">
                        <div class=""me-2"">
                            <span class=""badge bg-label-primary p-2""><i class=""bx bx-dollar text-primary""></i></span>
                        </div>
                        <div class=""d-flex flex-column"">
                            <small>2022");
            WriteLiteral(@"</small>
                            <h6 class=""mb-0"">$47.5k</h6>
                        </div>
                    </div>
                    <div class=""d-flex"">
                        <div class=""me-2"">
                            <span class=""badge bg-label-info p-2""><i class=""bx bx-wallet text-info""></i></span>
                        </div>
                        <div class=""d-flex flex-column"">
                            <small>2021</small>
                            <h6 class=""mb-0"">$41.2k</h6>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
