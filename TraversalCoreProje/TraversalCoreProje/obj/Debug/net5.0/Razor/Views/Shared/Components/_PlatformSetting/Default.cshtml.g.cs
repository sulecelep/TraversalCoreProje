#pragma checksum "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_PlatformSetting\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73f51aefa94c2d422648bde66ee731d9113599e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__PlatformSetting_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_PlatformSetting/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73f51aefa94c2d422648bde66ee731d9113599e5", @"/Views/Shared/Components/_PlatformSetting/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a51958c9bf37a05153a1f850f6d853d08112d134", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__PlatformSetting_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
 <div class=""col-12 col-xl-4"">
          <div class=""card h-100"">
            <div class=""card-header pb-0 p-3"">
              <h6 class=""mb-0"">Platform Ayarları</h6>
            </div>
            <div class=""card-body p-3"">
              <h6 class=""text-uppercase text-body text-xs font-weight-bolder"">Hesap</h6>
              <ul class=""list-group"">
                <li class=""list-group-item border-0 px-0"">
                  <div class=""form-check form-switch ps-0"">
                    <input class=""form-check-input ms-auto"" type=""checkbox"" id=""flexSwitchCheckDefault"" checked>
                    <label class=""form-check-label text-body ms-3 text-truncate w-80 mb-0"" for=""flexSwitchCheckDefault"">İki adımlı doğrulamayı aktifleştir.</label>
                  </div>
                </li>
                <li class=""list-group-item border-0 px-0"">
                  <div class=""form-check form-switch ps-0"">
                    <input class=""form-check-input ms-auto"" type=""checkbox"" id=""flexSwitchC");
            WriteLiteral(@"heckDefault1"">
                    <label class=""form-check-label text-body ms-3 text-truncate w-80 mb-0"" for=""flexSwitchCheckDefault1"">Her üç ayda bir şifrem güncelle.</label>
                  </div>
                </li>
                <li class=""list-group-item border-0 px-0"">
                  <div class=""form-check form-switch ps-0"">
                    <input class=""form-check-input ms-auto"" type=""checkbox"" id=""flexSwitchCheckDefault2"" checked>
                    <label class=""form-check-label text-body ms-3 text-truncate w-80 mb-0"" for=""flexSwitchCheckDefault2"">Mention işlemlerinde bana mail gönder.</label>
                  </div>
                </li>
              </ul>
              <h6 class=""text-uppercase text-body text-xs font-weight-bolder mt-4"">Mail Bülteni</h6>
              <ul class=""list-group"">
                <li class=""list-group-item border-0 px-0"">
                  <div class=""form-check form-switch ps-0"">
                    <input class=""form-check-input ms-auto""");
            WriteLiteral(@" type=""checkbox"" id=""flexSwitchCheckDefault3"">
                    <label class=""form-check-label text-body ms-3 text-truncate w-80 mb-0"" for=""flexSwitchCheckDefault3"">Yeni tur rotaları eklenince haber ver.</label>
                  </div>
                </li>
                <li class=""list-group-item border-0 px-0"">
                  <div class=""form-check form-switch ps-0"">
                    <input class=""form-check-input ms-auto"" type=""checkbox"" id=""flexSwitchCheckDefault4"" checked>
                    <label class=""form-check-label text-body ms-3 text-truncate w-80 mb-0"" for=""flexSwitchCheckDefault4"">Aylık tur bülteni hakkında mail gönder.</label>
                  </div>
                </li>
                <li class=""list-group-item border-0 px-0 pb-0"">
                  <div class=""form-check form-switch ps-0"">
                    <input class=""form-check-input ms-auto"" type=""checkbox"" id=""flexSwitchCheckDefault5"">
                    <label class=""form-check-label text-body ms-3 text");
            WriteLiteral("-truncate w-80 mb-0\" for=\"flexSwitchCheckDefault5\">Youtube\'da yeni video paylaşınca bilgilendir.\'</label>\r\n                  </div>\r\n                </li>\r\n              </ul>\r\n            </div>\r\n          </div>\r\n        </div>\r\n");
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
