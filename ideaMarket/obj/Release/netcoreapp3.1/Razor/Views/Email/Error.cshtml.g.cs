#pragma checksum "C:\Users\Tafadzwa\source\repos\ideaMarket\ideaMarket\Views\Email\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4caadc594278c0121cd705eb9e4ffe24235437b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ideaMarket.Pages.Email.Views_Email_Error), @"mvc.1.0.view", @"/Views/Email/Error.cshtml")]
namespace ideaMarket.Pages.Email
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
#line 1 "C:\Users\Tafadzwa\source\repos\ideaMarket\ideaMarket\Views\_ViewImports.cshtml"
using ideaMarket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tafadzwa\source\repos\ideaMarket\ideaMarket\Views\_ViewImports.cshtml"
using ideaMarket.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tafadzwa\source\repos\ideaMarket\ideaMarket\Views\_ViewImports.cshtml"
using ideaMarket.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tafadzwa\source\repos\ideaMarket\ideaMarket\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tafadzwa\source\repos\ideaMarket\ideaMarket\Views\_ViewImports.cshtml"
using ideaMarket.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4caadc594278c0121cd705eb9e4ffe24235437b6", @"/Views/Email/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d428318e6dd47865dbe9960b35e7824741e6c8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Email_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Tafadzwa\source\repos\ideaMarket\ideaMarket\Views\Email\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-area-investors"">
    <div class=""breadcumb-overlay""></div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12 col-sm-12 col-xs-12"">
                <div class=""breadcrumb text-center"">
                    <div class=""section-headline white-headline"">
                        <h3>Confirm Email </h3>
                    </div>
                    <ul class=""breadcrumb-bg"">
                        <li class=""home-bread"">Home</li>
                        <li>Confirm Email</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>
<br />
<h1 class=""text-danger"">Error</h1>
<h2 class=""text-danger"">An error occurred while processing your request. Please try again later.</h2>


");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
