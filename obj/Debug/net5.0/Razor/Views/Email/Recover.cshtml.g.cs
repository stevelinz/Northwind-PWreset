#pragma checksum "D:\DEVELOPMENT\DotnetASPCLASS\13MOD\Northwind-PWreset\Views\Email\Recover.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20ffe265be22e3d4aae92022837a11fecd31d943"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Email_Recover), @"mvc.1.0.view", @"/Views/Email/Recover.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20ffe265be22e3d4aae92022837a11fecd31d943", @"/Views/Email/Recover.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6821e55d58e521d8ec88e3dd76f39397f4fcf86", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Email_Recover : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\DEVELOPMENT\DotnetASPCLASS\13MOD\Northwind-PWreset\Views\Email\Recover.cshtml"
  
    ViewData["Title"] = "Password Recovery";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Password Recovery</h1>\r\n   \r\n\r\n");
#nullable restore
#line 9 "D:\DEVELOPMENT\DotnetASPCLASS\13MOD\Northwind-PWreset\Views\Email\Recover.cshtml"
     using (Html.BeginForm("Recover", "Email", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
            <div class=""form-group col-md-6"">
                <input type=""email"" class=""form-control"" name=""toEmail"" />
            </div>
            <div class=""form-group col-md-6"">
                <input type=""submit"" value=""Send Email"" />
            </div>
        </div>
");
#nullable restore
#line 19 "D:\DEVELOPMENT\DotnetASPCLASS\13MOD\Northwind-PWreset\Views\Email\Recover.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\DEVELOPMENT\DotnetASPCLASS\13MOD\Northwind-PWreset\Views\Email\Recover.cshtml"
     if (ViewBag.EmailSentMessage != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"bg-success\">\r\n            <label>");
#nullable restore
#line 23 "D:\DEVELOPMENT\DotnetASPCLASS\13MOD\Northwind-PWreset\Views\Email\Recover.cshtml"
              Write(ViewBag.EmailSentMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n");
#nullable restore
#line 25 "D:\DEVELOPMENT\DotnetASPCLASS\13MOD\Northwind-PWreset\Views\Email\Recover.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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