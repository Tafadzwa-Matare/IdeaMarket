#pragma checksum "C:\Users\mataret\source\repos\ideaMarket\ideaMarket\Views\Investors\Investors.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a2060d449082543f461bbe30fbfb09e2512494f35ebf4d98c6c587b92a0aad59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ideaMarket.Pages.Investors.Views_Investors_Investors), @"mvc.1.0.view", @"/Views/Investors/Investors.cshtml")]
namespace ideaMarket.Pages.Investors
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\mataret\source\repos\ideaMarket\ideaMarket\Views\_ViewImports.cshtml"
using ideaMarket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mataret\source\repos\ideaMarket\ideaMarket\Views\_ViewImports.cshtml"
using ideaMarket.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mataret\source\repos\ideaMarket\ideaMarket\Views\_ViewImports.cshtml"
using ideaMarket.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mataret\source\repos\ideaMarket\ideaMarket\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mataret\source\repos\ideaMarket\ideaMarket\Views\_ViewImports.cshtml"
using ideaMarket.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a2060d449082543f461bbe30fbfb09e2512494f35ebf4d98c6c587b92a0aad59", @"/Views/Investors/Investors.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"52c2fdb8296595c12919a90a42706dafed4adf6d5788a6dc3de467b310a37122", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Investors_Investors : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ideaMarket.ViewModels.InvestorViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Platform/UserPublicProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mataret\source\repos\ideaMarket\ideaMarket\Views\Investors\Investors.cshtml"
  
    ViewData["Title"] = "InvestorsView";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        var items = $('.single-member');
        var numItems = items.length;
        var perPage = 8;

        items.slice(perPage).hide();

        $('#pagination-container').pagination({
            items: numItems,
            itemsOnPage: perPage,
            prevText: ""<"",
            nextText: "">"",
            onPageClick: function (pageNumber) {
                var showFrom = perPage * (pageNumber - 1);
                var showTo = showFrom + perPage;
                items.hide().slice(showFrom, showTo).show();
            }
        })
    </script>
");
            }
            );
            WriteLiteral(@"
<div class=""page-area-investors"">
    <div class=""breadcumb-overlay""></div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12 col-sm-12 col-xs-12"">
                <div class=""breadcrumb text-center"">
                    <div class=""section-headline white-headline"">
                        <h3>Investors </h3>
                    </div>
                    <ul class=""breadcrumb-bg"">
                        <li class=""home-bread"">Home</li>
                        <li>Our Investors</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- End breadcumb Area -->
<!-- Team area start -->
<div class=""team-page-area page-padding-2"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12 col-sm-12 col-xs-12"">
                <div class=""section-headline text-center"">
                    <h3>Our Top Investors</h3>
                    <p>Help Idea Owners to define their");
            WriteLiteral(" new business Ideas and then create professional Solutions.</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n");
            WriteLiteral("\r\n        <div class=\"row\">\r\n            <div class=\"team-member text-center\">\r\n                <!-- Single team member -->\r\n\r\n");
#nullable restore
#line 86 "C:\Users\mataret\source\repos\ideaMarket\ideaMarket\Views\Investors\Investors.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-3 col-sm-6 col-xs-12\">\r\n                        <div class=\"single-member\">\r\n                            <div class=\"team-img\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2060d449082543f461bbe30fbfb09e2512494f35ebf4d98c6c587b92a0aad597099", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 93 "C:\Users\mataret\source\repos\ideaMarket\ideaMarket\Views\Investors\Investors.cshtml"
                                     if (item.ProfilePicture == null)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <img src=\"../ProfilePictures/userdefault.png\"");
                BeginWriteAttribute("alt", " alt=\"", 3426, "\"", 3432, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 96 "C:\Users\mataret\source\repos\ideaMarket\ideaMarket\Views\Investors\Investors.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <img");
                BeginWriteAttribute("src", " src=\"", 3600, "\"", 3645, 2);
                WriteAttributeValue("", 3606, "../ProfilePictures/", 3606, 19, true);
#nullable restore
#line 99 "C:\Users\mataret\source\repos\ideaMarket\ideaMarket\Views\Investors\Investors.cshtml"
WriteAttributeValue("", 3625, item.ProfilePicture, 3625, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 3646, "\"", 3652, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 100 "C:\Users\mataret\source\repos\ideaMarket\ideaMarket\Views\Investors\Investors.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\Users\mataret\source\repos\ideaMarket\ideaMarket\Views\Investors\Investors.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"team-content\">\r\n                                <h5> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2060d449082543f461bbe30fbfb09e2512494f35ebf4d98c6c587b92a0aad5911218", async() => {
#nullable restore
#line 105 "C:\Users\mataret\source\repos\ideaMarket\ideaMarket\Views\Investors\Investors.cshtml"
                                                                                                      Write(item.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 105 "C:\Users\mataret\source\repos\ideaMarket\ideaMarket\Views\Investors\Investors.cshtml"
                                                                                                                      Write(item.Surname);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 105 "C:\Users\mataret\source\repos\ideaMarket\ideaMarket\Views\Investors\Investors.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h5>\r\n                                <p>");
#nullable restore
#line 106 "C:\Users\mataret\source\repos\ideaMarket\ideaMarket\Views\Investors\Investors.cshtml"
                              Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <ul class=\"team-hover\">\r\n\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 4160, "\"", 4185, 2);
            WriteAttributeValue("", 4167, "mailto:", 4167, 7, true);
#nullable restore
#line 109 "C:\Users\mataret\source\repos\ideaMarket\ideaMarket\Views\Investors\Investors.cshtml"
WriteAttributeValue("", 4174, item.Email, 4174, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-envelope\"></i></a></li>\r\n                                </ul>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 114 "C:\Users\mataret\source\repos\ideaMarket\ideaMarket\Views\Investors\Investors.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div id=\"pagination-container\">\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ideaMarket.ViewModels.InvestorViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591