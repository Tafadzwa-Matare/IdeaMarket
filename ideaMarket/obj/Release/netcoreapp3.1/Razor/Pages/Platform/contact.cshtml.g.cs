#pragma checksum "C:\Users\Tafadzwa\source\repos\ideaMarket\ideaMarket\Pages\Platform\contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2dd466b8c1f0a3ae0c1186ead46f59cb73d5b4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ideaMarket.Pages.Platform.Pages_Platform_contact), @"mvc.1.0.razor-page", @"/Pages/Platform/contact.cshtml")]
namespace ideaMarket.Pages.Platform
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
#line 1 "C:\Users\Tafadzwa\source\repos\ideaMarket\ideaMarket\Pages\_ViewImports.cshtml"
using ideaMarket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tafadzwa\source\repos\ideaMarket\ideaMarket\Pages\_ViewImports.cshtml"
using ideaMarket.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tafadzwa\source\repos\ideaMarket\ideaMarket\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tafadzwa\source\repos\ideaMarket\ideaMarket\Pages\_ViewImports.cshtml"
using ideaMarket.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2dd466b8c1f0a3ae0c1186ead46f59cb73d5b4e", @"/Pages/Platform/contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cd4eab808d7b62897fc894d30fcbf6cc42115d4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Platform_contact : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Tafadzwa\source\repos\ideaMarket\ideaMarket\Pages\Platform\contact.cshtml"
  
    ViewData["Title"] = "contact";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Start breadcumb Area -->
<div class=""page-area-contacts"">
    <div class=""breadcumb-overlay""></div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12 col-sm-12 col-xs-12"">
                <div class=""breadcrumb text-center"">
                    <div class=""section-headline white-headline"">
                        <h3>Contact us</h3>
                    </div>
                    <ul class=""breadcrumb-bg"">
                        <li class=""home-bread"">Home</li>
                        <li>Contact us</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- End breadcumb Area -->
<!-- Start contact Area -->
<div class=""contact-area page-padding"">
    <div class=""container"">
        <div class=""row"">
            <div class=""contact-inner"">
                <!-- Start contact icon column -->
                <div class=""col-md-4 col-sm-4 col-xs-12 wow fadeInLeft""data-wow-delay=""300ms"">
     ");
            WriteLiteral(@"               <div class=""contact-icon text-center"">
                        <div class=""single-icon"">
                            <i class=""fa fa-mobile""></i>
                            <p>
                                Call : +263773732842<br>
                                <span>Monday-Sunday (24/7)</span>
                            </p>
                        </div>
                    </div>
                </div>
                <!-- Start contact icon column -->
                <div class=""col-md-4 col-sm-4 col-xs-12 wow fadeInUp"" data-wow-delay=""500ms"">
                    <div class=""contact-icon text-center"">
                        <div class=""single-icon"">
                            <i class=""fa fa-envelope-o""></i>
                            <p>
                                Email : ideamarketglobal@gmail.com<br>
                                <span>Web: www.ideamarket.co.zw</span>
                            </p>
                        </div>
                    <");
            WriteLiteral(@"/div>
                </div>
                <!-- Start contact icon column -->
                <div class=""col-md-4 col-sm-4 col-xs-12 wow fadeInRight"" data-wow-delay=""300ms"">
                    <div class=""contact-icon text-center"">
                        <div class=""single-icon"">
                            <i class=""fa fa-map-marker""></i>
                            <p>
                                Location : 17 Park Street, Shanda House, Harare<br>
                                <span>2nd floor, Suite 10</span>
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
     
    </div>
</div>
<!-- End Contact Area -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ideaMarket.Pages.Platform.contactModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ideaMarket.Pages.Platform.contactModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ideaMarket.Pages.Platform.contactModel>)PageContext?.ViewData;
        public ideaMarket.Pages.Platform.contactModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
