#pragma checksum "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7a8c1d1861de97d6e6a11c40c4b5dc78d6a62d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Destination_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Destination/Index.cshtml")]
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
#line 1 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using DTOLayer.DTOs.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Results.DestinationResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Results.GuideResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Commands.DestinationCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Commands.GuideCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7a8c1d1861de97d6e6a11c40c4b5dc78d6a62d1", @"/Areas/Admin/Views/Destination/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27e5393695708f4286334c8af6d9866b2749544e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Destination_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Tur Rotaları</h1>
<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Şehir</th>
        <th>Fiyat</th>
        <th>Kapasite</th>
        <th>Sitede Gör</th>
        <th>Sil</th>
        <th>Güncelle</th>
    </tr>
");
#nullable restore
#line 19 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
           Write(item.DestinationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
           Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
           Write(item.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> <a");
            BeginWriteAttribute("href", " href=\"", 625, "\"", 684, 3);
            WriteAttributeValue("", 632, "/Destination/DestinationDetails/", 632, 32, true);
#nullable restore
#line 26 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
WriteAttributeValue("", 664, item.DestinationID, 664, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 683, "/", 683, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Sitede Gör</a> </td>\r\n            <td> <a");
            BeginWriteAttribute("href", " href=\"", 756, "\"", 820, 3);
            WriteAttributeValue("", 763, "/Admin/Destination/DeleteDestination/", 763, 37, true);
#nullable restore
#line 27 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
WriteAttributeValue("", 800, item.DestinationID, 800, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 819, "/", 819, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a> </td>\r\n            <td> <a");
            BeginWriteAttribute("href", " href=\"", 887, "\"", 950, 2);
            WriteAttributeValue("", 894, "/Admin/Destination/UpdateDestination/", 894, 37, true);
#nullable restore
#line 28 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
WriteAttributeValue("", 931, item.DestinationID, 931, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a> </td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\CELEP\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</table>\r\n<a href=\"/Admin/Destination/AddDestination/\" class=\"btn btn-outline-primary\">Yeni Tur Rotası</a>\r\n\r\n");
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
