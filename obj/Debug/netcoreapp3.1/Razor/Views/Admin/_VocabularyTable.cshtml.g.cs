#pragma checksum "/home/p/Documents/Code/vocabadmin/Views/Admin/_VocabularyTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8add12bac944c4aae05fa11798106484ea2814bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin__VocabularyTable), @"mvc.1.0.view", @"/Views/Admin/_VocabularyTable.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8add12bac944c4aae05fa11798106484ea2814bf", @"/Views/Admin/_VocabularyTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67bad1bc65e26b37a08947ffb01601b561912f93", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin__VocabularyTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<vocabadmin.Models.Vocabulary>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/p/Documents/Code/vocabadmin/Views/Admin/_VocabularyTable.cshtml"
  
    int row = (int)ViewBag.RowNumber;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<table class=\"table\" id=\"vocab_table\">\n    <thead>\n        <tr>\n            <th scope=\"col\">#</th>\n            <th scope=\"col\">");
#nullable restore
#line 11 "/home/p/Documents/Code/vocabadmin/Views/Admin/_VocabularyTable.cshtml"
                       Write(Html.DisplayNameFor(m => m.Word));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th scope=\"col\">");
#nullable restore
#line 12 "/home/p/Documents/Code/vocabadmin/Views/Admin/_VocabularyTable.cshtml"
                       Write(Html.DisplayNameFor(m => m.Word));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th scope=\"col\">");
#nullable restore
#line 13 "/home/p/Documents/Code/vocabadmin/Views/Admin/_VocabularyTable.cshtml"
                       Write(Html.DisplayNameFor(m => m.Word));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 17 "/home/p/Documents/Code/vocabadmin/Views/Admin/_VocabularyTable.cshtml"
         for(var i = 0; i < row; i++)
            {
                string idRow = "vocab_row_" + i.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("id", " id=\"", 551, "\"", 562, 1);
#nullable restore
#line 20 "/home/p/Documents/Code/vocabadmin/Views/Admin/_VocabularyTable.cshtml"
WriteAttributeValue("", 556, idRow, 556, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    <td scope=\"col\">#</td>\n                    <td scope=\"col\">");
#nullable restore
#line 22 "/home/p/Documents/Code/vocabadmin/Views/Admin/_VocabularyTable.cshtml"
                               Write(Html.DisplayNameFor(m => m.Word));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td scope=\"col\">");
#nullable restore
#line 23 "/home/p/Documents/Code/vocabadmin/Views/Admin/_VocabularyTable.cshtml"
                               Write(Html.DisplayNameFor(m => m.Word));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td scope=\"col\">");
#nullable restore
#line 24 "/home/p/Documents/Code/vocabadmin/Views/Admin/_VocabularyTable.cshtml"
                               Write(Html.DisplayNameFor(m => m.Word));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 26 "/home/p/Documents/Code/vocabadmin/Views/Admin/_VocabularyTable.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
