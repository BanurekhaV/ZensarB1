#pragma checksum "E:\Banu\Zensar\Batch1\Core\CoreEFDbFirst\CoreEFDbFirst\Views\Home\GetDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2552fb9a2c1668987fb069129efe48d7bbda624"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetDetails), @"mvc.1.0.view", @"/Views/Home/GetDetails.cshtml")]
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
#line 1 "E:\Banu\Zensar\Batch1\Core\CoreEFDbFirst\CoreEFDbFirst\Views\_ViewImports.cshtml"
using CoreEFDbFirst;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Banu\Zensar\Batch1\Core\CoreEFDbFirst\CoreEFDbFirst\Views\_ViewImports.cshtml"
using CoreEFDbFirst.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2552fb9a2c1668987fb069129efe48d7bbda624", @"/Views/Home/GetDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ce9b8e3574bd8fda3cf69fd1aac4b2d97f59cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreEFDbFirst.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Banu\Zensar\Batch1\Core\CoreEFDbFirst\CoreEFDbFirst\Views\Home\GetDetails.cshtml"
  
    ViewData["Title"] = "GetDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Get product Details</h1>\r\n");
#nullable restore
#line 7 "E:\Banu\Zensar\Batch1\Core\CoreEFDbFirst\CoreEFDbFirst\Views\Home\GetDetails.cshtml"
 foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 9 "E:\Banu\Zensar\Batch1\Core\CoreEFDbFirst\CoreEFDbFirst\Views\Home\GetDetails.cshtml"
               Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li>");
#nullable restore
#line 10 "E:\Banu\Zensar\Batch1\Core\CoreEFDbFirst\CoreEFDbFirst\Views\Home\GetDetails.cshtml"
               Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li>");
#nullable restore
#line 11 "E:\Banu\Zensar\Batch1\Core\CoreEFDbFirst\CoreEFDbFirst\Views\Home\GetDetails.cshtml"
               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li>");
#nullable restore
#line 12 "E:\Banu\Zensar\Batch1\Core\CoreEFDbFirst\CoreEFDbFirst\Views\Home\GetDetails.cshtml"
               Write(item.QuantityAvailable);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <br/>\r\n");
#nullable restore
#line 14 "E:\Banu\Zensar\Batch1\Core\CoreEFDbFirst\CoreEFDbFirst\Views\Home\GetDetails.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreEFDbFirst.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
