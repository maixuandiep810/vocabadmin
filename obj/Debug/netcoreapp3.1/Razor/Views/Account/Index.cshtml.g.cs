#pragma checksum "/home/p/Documents/Code/vocabadmin/Views/Account/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bfb5373ff31c107837f389446406026df2c4687"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bfb5373ff31c107837f389446406026df2c4687", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67bad1bc65e26b37a08947ffb01601b561912f93", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<vocabadmin.Models.AuthenticateRequest>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "/home/p/Documents/Code/vocabadmin/Views/Account/Index.cshtml"
  
    ViewBag.Title = "Login";
    string API_SERVER = (ViewBag.API_SERVER) as string;
    string LOGIN_URL = API_SERVER + "/api/user/autenticate";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row justify-content-md-center\">\r\n    <div class=\"col-md-4\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header\">\r\n                Login\r\n            </div>\r\n            <div class=\"card-body\">\r\n");
#nullable restore
#line 17 "/home/p/Documents/Code/vocabadmin/Views/Account/Index.cshtml"
                     using (Html.BeginForm())
                    {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/home/p/Documents/Code/vocabadmin/Views/Account/Index.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 21 "/home/p/Documents/Code/vocabadmin/Views/Account/Index.cshtml"
                   Write(Html.LabelFor(m => m.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 22 "/home/p/Documents/Code/vocabadmin/Views/Account/Index.cshtml"
                   Write(Html.TextBoxFor(m => m.Username, "", new { @class = "form-control", @placeholder = "Username" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 26 "/home/p/Documents/Code/vocabadmin/Views/Account/Index.cshtml"
                   Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 27 "/home/p/Documents/Code/vocabadmin/Views/Account/Index.cshtml"
                   Write(Html.PasswordFor(m => m.Password, new { @class = "form-control", @placeholder = "Password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <button id=\"btnSubmit\" class=\"btn btn-primary\">Login</button>\r\n                    </div>\r\n");
#nullable restore
#line 32 "/home/p/Documents/Code/vocabadmin/Views/Account/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 40 "/home/p/Documents/Code/vocabadmin/Views/Account/Index.cshtml"
      Html.RenderPartial("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <script>
         $(document).ready(function () 
         {
            $('#btnSubmit').on('click', function () {
                login();
            });
            
        });
            function login() {
            $.ajax({
                url: ""https://localhost:5000/api/user/autenticate"",
                type: ""POST"",
                dataType: ""json"",
                success: function (result) {
                    var mess = result[""message""];
                    alert(mess);
                },
                error: function (errormessage) {
                    alert(errormessage.responseText);
                }
            }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<vocabadmin.Models.AuthenticateRequest> Html { get; private set; }
    }
}
#pragma warning restore 1591
