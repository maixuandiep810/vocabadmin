#pragma checksum "/home/p/Documents/Code/vocabadmin/Areas/testrazor/Pages/About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b12f2302507b91da98c4522fb0f02f0db690c05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_testrazor_Pages_About), @"mvc.1.0.razor-page", @"/Areas/testrazor/Pages/About.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b12f2302507b91da98c4522fb0f02f0db690c05", @"/Areas/testrazor/Pages/About.cshtml")]
    public class Areas_testrazor_Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/p/Documents/Code/vocabadmin/Areas/testrazor/Pages/About.cshtml"
  
    Layout = "_Layout"; // Thiết lập Layout của trang (View/Shared/_Layout.cshtml)

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"alert alert-danger\">\r\n  Đây là trang Razor trong MVC\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<vocabteam.testrazor.AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<vocabteam.testrazor.AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<vocabteam.testrazor.AboutModel>)PageContext?.ViewData;
        public vocabteam.testrazor.AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
