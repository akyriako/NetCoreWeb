#pragma checksum "E:\project\NetCoreWeb\NetCoreSQL\Views\File\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ec77a3156f884b924c4f09eda74d6ef56d6d049"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_File_Index), @"mvc.1.0.view", @"/Views/File/Index.cshtml")]
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
#line 1 "E:\project\NetCoreWeb\NetCoreSQL\Views\_ViewImports.cshtml"
using NetCoreSQL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\project\NetCoreWeb\NetCoreSQL\Views\_ViewImports.cshtml"
using NetCoreSQL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ec77a3156f884b924c4f09eda74d6ef56d6d049", @"/Views/File/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64710b15599d48d0cdb235773594fa358792d6ae", @"/Views/_ViewImports.cshtml")]
    public class Views_File_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FileShareData>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\project\NetCoreWeb\NetCoreSQL\Views\File\Index.cshtml"
  
    ViewData["Title"] = "ShowAllFiles";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>ShowAllFiles</h1>
<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>FileName</th>
            <th>FileSize</th>
            <th>ModifiedOn</th>
            <th>Download</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 17 "E:\project\NetCoreWeb\NetCoreSQL\Views\File\Index.cshtml"
         foreach (var data in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "E:\project\NetCoreWeb\NetCoreSQL\Views\File\Index.cshtml"
               Write(data.FileName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "E:\project\NetCoreWeb\NetCoreSQL\Views\File\Index.cshtml"
               Write(data.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "E:\project\NetCoreWeb\NetCoreSQL\Views\File\Index.cshtml"
               Write(data.LastModified);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> <a");
            BeginWriteAttribute("href", " href=\"", 547, "\"", 592, 2);
            WriteAttributeValue("", 554, "/File/Download?fileName=", 554, 24, true);
#nullable restore
#line 23 "E:\project\NetCoreWeb\NetCoreSQL\Views\File\Index.cshtml"
WriteAttributeValue("", 578, data.FileName, 578, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Download</a> </td>\r\n            </tr>\r\n");
#nullable restore
#line 25 "E:\project\NetCoreWeb\NetCoreSQL\Views\File\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FileShareData>> Html { get; private set; }
    }
}
#pragma warning restore 1591
