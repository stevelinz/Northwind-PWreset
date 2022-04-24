#pragma checksum "D:\DEVELOPMENT\DotnetASPCLASS\13MOD\Northwind-Web-restful-web-services-2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d71fef682c054c717264c274c7e705762de28eeb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\DEVELOPMENT\DotnetASPCLASS\13MOD\Northwind-Web-restful-web-services-2\Views\_ViewImports.cshtml"
using Northwind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\DEVELOPMENT\DotnetASPCLASS\13MOD\Northwind-Web-restful-web-services-2\Views\Home\Index.cshtml"
using Northwind.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d71fef682c054c717264c274c7e705762de28eeb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6821e55d58e521d8ec88e3dd76f39397f4fcf86", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Discount>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/client.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""jumbotron my-2 border border-secondary"">
    <h1 class=""display-4"">Northwind</h1>
    <p class=""lead"">We have the best prices and selection of high quality foods &amp; beverages on the planet! Check out our featured discounts below.</p>
    <hr class=""my-4"">
    <p>For exceptional international quisuine, look no further.</p>
    <a class=""btn btn-outline-primary btn-lg"" href=""#"" role=""button""><i class=""fas fa-shopping-cart""></i> Order Now</a>
</div>

<div class=""row row-cols-1 row-cols-lg-3"">
");
#nullable restore
#line 13 "D:\DEVELOPMENT\DotnetASPCLASS\13MOD\Northwind-Web-restful-web-services-2\Views\Home\Index.cshtml"
     foreach (Discount d in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col discounts px-2 py-4\">\n            <h3>");
#nullable restore
#line 16 "D:\DEVELOPMENT\DotnetASPCLASS\13MOD\Northwind-Web-restful-web-services-2\Views\Home\Index.cshtml"
           Write(d.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n            <div class=\"mb-4\">\n                ");
#nullable restore
#line 18 "D:\DEVELOPMENT\DotnetASPCLASS\13MOD\Northwind-Web-restful-web-services-2\Views\Home\Index.cshtml"
           Write(d.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <i>Discount expires: ");
#nullable restore
#line 20 "D:\DEVELOPMENT\DotnetASPCLASS\13MOD\Northwind-Web-restful-web-services-2\Views\Home\Index.cshtml"
                            Write(d.EndTime.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i><br />\n            <a href=\"#\" class=\"code\" data-code=\"");
#nullable restore
#line 21 "D:\DEVELOPMENT\DotnetASPCLASS\13MOD\Northwind-Web-restful-web-services-2\Views\Home\Index.cshtml"
                                           Write(d.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-product=\"");
#nullable restore
#line 21 "D:\DEVELOPMENT\DotnetASPCLASS\13MOD\Northwind-Web-restful-web-services-2\Views\Home\Index.cshtml"
                                                                  Write(d.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"far fa-hand-point-right\"></i> Discount Code</a>\n        </div>\n");
#nullable restore
#line 23 "D:\DEVELOPMENT\DotnetASPCLASS\13MOD\Northwind-Web-restful-web-services-2\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d71fef682c054c717264c274c7e705762de28eeb6662", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Discount>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591