#pragma checksum "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Areas\BeryAdmin\Views\Work\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d885503be946b7a04f0f7d65f27ee53fda2e77ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BeryAdmin_Views_Work_Detail), @"mvc.1.0.view", @"/Areas/BeryAdmin/Views/Work/Detail.cshtml")]
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
#line 1 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Areas\BeryAdmin\Views\_ViewImports.cshtml"
using Beryllium_Back_End.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Areas\BeryAdmin\Views\_ViewImports.cshtml"
using Beryllium_Back_End.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d885503be946b7a04f0f7d65f27ee53fda2e77ee", @"/Areas/BeryAdmin/Views/Work/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c211943933e19d2251e6e3fc76056ef9eff4692", @"/Areas/BeryAdmin/Views/_ViewImports.cshtml")]
    public class Areas_BeryAdmin_Views_Work_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Work>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Areas\BeryAdmin\Views\Work\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <div>\r\n        <p>Name:</p>\r\n        <h4>");
#nullable restore
#line 9 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Areas\BeryAdmin\Views\Work\Detail.cshtml"
       Write(Model.WorkName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n    <div>\r\n        <p>Description:</p>\r\n        <h4>");
#nullable restore
#line 13 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Areas\BeryAdmin\Views\Work\Detail.cshtml"
       Write(Model.WorkDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n    <div>\r\n        <p>Icon:</p>\r\n        <h4>");
#nullable restore
#line 17 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Areas\BeryAdmin\Views\Work\Detail.cshtml"
       Write(Model.WorkIcon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Work> Html { get; private set; }
    }
}
#pragma warning restore 1591
