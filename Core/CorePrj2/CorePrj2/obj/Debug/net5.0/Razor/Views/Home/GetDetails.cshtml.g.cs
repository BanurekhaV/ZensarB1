#pragma checksum "E:\Banu\Zensar\Batch1\Core\CorePrj2\CorePrj2\Views\Home\GetDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb8b024961e02c8172063582e13d99e64c9ea192"
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
#line 1 "E:\Banu\Zensar\Batch1\Core\CorePrj2\CorePrj2\Views\_ViewImports.cshtml"
using CorePrj2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb8b024961e02c8172063582e13d99e64c9ea192", @"/Views/Home/GetDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"488948faf6d078a6140de82ebb3487a3266ca8b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CorePrj2.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Banu\Zensar\Batch1\Core\CorePrj2\CorePrj2\Views\Home\GetDetails.cshtml"
  
    ViewData["Title"] = "GetDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>GetDetails</h1>\r\n<table>\r\n    <tr>\r\n        <td>Student Id :</td>\r\n        <td>");
#nullable restore
#line 10 "E:\Banu\Zensar\Batch1\Core\CorePrj2\CorePrj2\Views\Home\GetDetails.cshtml"
       Write(Model.StdId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Student Name :</td>\r\n        <td>");
#nullable restore
#line 14 "E:\Banu\Zensar\Batch1\Core\CorePrj2\CorePrj2\Views\Home\GetDetails.cshtml"
       Write(Model.StdName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Student Gender :</td>\r\n        <td>");
#nullable restore
#line 18 "E:\Banu\Zensar\Batch1\Core\CorePrj2\CorePrj2\Views\Home\GetDetails.cshtml"
       Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Course :</td>\r\n        <td>");
#nullable restore
#line 22 "E:\Banu\Zensar\Batch1\Core\CorePrj2\CorePrj2\Views\Home\GetDetails.cshtml"
       Write(Model.Discipline);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CorePrj2.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
