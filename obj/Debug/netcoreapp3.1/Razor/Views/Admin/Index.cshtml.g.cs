#pragma checksum "/home/p/Documents/Code/vocabadmin/Views/Admin/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e230b8077dbe539bc0417a9cc77062892c64f491"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "/home/p/Documents/Code/vocabadmin/Views/_ViewImports.cshtml"
using vocabadmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/p/Documents/Code/vocabadmin/Views/_ViewImports.cshtml"
using vocabadmin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e230b8077dbe539bc0417a9cc77062892c64f491", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67bad1bc65e26b37a08947ffb01601b561912f93", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<vocabadmin.Models.Vocabulary>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/p/Documents/Code/vocabadmin/Views/Admin/Index.cshtml"
  
    ViewBag.Title = "Admin";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Header", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 10 "/home/p/Documents/Code/vocabadmin/Views/Admin/Index.cshtml"
      Html.RenderPartial("_HeaderAdmin");

#line default
#line hidden
#nullable disable
                WriteLiteral("    \r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <div id=\"data_area\">\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 24 "/home/p/Documents/Code/vocabadmin/Views/Admin/Index.cshtml"
      Html.RenderPartial("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <script>
        $(document).ready(function () 
            {


                $(""#vocabulary_nav"").click(function (event) {
                    event.preventDefault();
                    var url = ""https://localhost:5005/admin/vocabularytable/1"";
                    $(""#data_area"").load(url);
                });
            }
        );
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n                \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<vocabadmin.Models.Vocabulary> Html { get; private set; }
    }
}
#pragma warning restore 1591
