#pragma checksum "D:\DEVELOPMENT\DotnetASPCLASS\13MOD\Northwind-PWreset\Views\EmailVerify\RecoverPair.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52e30a71af6ba5cb47ee2e9ae5f6776640c1f69e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmailVerify_RecoverPair), @"mvc.1.0.view", @"/Views/EmailVerify/RecoverPair.cshtml")]
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
#line 1 "D:\DEVELOPMENT\DotnetASPCLASS\13MOD\Northwind-PWreset\Views\_ViewImports.cshtml"
using Northwind;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52e30a71af6ba5cb47ee2e9ae5f6776640c1f69e", @"/Views/EmailVerify/RecoverPair.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6821e55d58e521d8ec88e3dd76f39397f4fcf86", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_EmailVerify_RecoverPair : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\DEVELOPMENT\DotnetASPCLASS\13MOD\Northwind-PWreset\Views\EmailVerify\RecoverPair.cshtml"
  
    ViewData["Title"] = "Password Reset Verifcation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-left\">\r\n    <h1 class=\"display-4\">Password Reset Verifcation</h1>\r\n   \r\n\r\n");
#nullable restore
#line 9 "D:\DEVELOPMENT\DotnetASPCLASS\13MOD\Northwind-PWreset\Views\EmailVerify\RecoverPair.cshtml"
     using (Html.BeginForm("RecoverPair", "EmailVerify", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
            <div class=""form-group col-md-6"">
                <label for=""toEmail"">Enter Email</label>
                <input type=""text"" class=""form-control"" name=""toEmail"" /><br>
                <label for=""codeVerifyTest"">Enter 4-Digit Code</label>
                <input type=""text"" class=""form-control"" name=""codeVerifyTest"" /><br>
                <input type=""submit"" value=""Send Email"" />
            </div>
        </div>
");
#nullable restore
#line 20 "D:\DEVELOPMENT\DotnetASPCLASS\13MOD\Northwind-PWreset\Views\EmailVerify\RecoverPair.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\DEVELOPMENT\DotnetASPCLASS\13MOD\Northwind-PWreset\Views\EmailVerify\RecoverPair.cshtml"
     if (ViewBag.EmailSentMessage != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"bg-success\">\r\n            <label>");
#nullable restore
#line 24 "D:\DEVELOPMENT\DotnetASPCLASS\13MOD\Northwind-PWreset\Views\EmailVerify\RecoverPair.cshtml"
              Write(ViewBag.EmailSentMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n");
#nullable restore
#line 26 "D:\DEVELOPMENT\DotnetASPCLASS\13MOD\Northwind-PWreset\Views\EmailVerify\RecoverPair.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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