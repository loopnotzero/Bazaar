#pragma checksum "/home/briankernighan/IdeaProjects/Advert/Bazaar/Views/Shared/ProfilePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aecded5b6599b4ab5fad00b4306839a888c40e68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ProfilePartial), @"mvc.1.0.view", @"/Views/Shared/ProfilePartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ProfilePartial.cshtml", typeof(AspNetCore.Views_Shared_ProfilePartial))]
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
#line 1 "/home/briankernighan/IdeaProjects/Advert/Bazaar/Views/Shared/ProfilePartial.cshtml"
using Bazaar.Models.Profiles;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aecded5b6599b4ab5fad00b4306839a888c40e68", @"/Views/Shared/ProfilePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0909514ccbe15c9b46987fb6fc827edf50cf04a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ProfilePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("profile-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/no-image.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("team__img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(54, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "/home/briankernighan/IdeaProjects/Advert/Bazaar/Views/Shared/ProfilePartial.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(77, 33, true);
            WriteLiteral("    <div class=\"profile-header\">\n");
            EndContext();
#line 7 "/home/briankernighan/IdeaProjects/Advert/Bazaar/Views/Shared/ProfilePartial.cshtml"
         if (Model.Owner)
        {

#line default
#line hidden
            BeginContext(146, 133, true);
            WriteLiteral("            <a href=\"#\" class=\"zmdi zmdi-edit float-right\" data-toggle=\"modal\" data-target=\"#edit__profile--modal\">\n            </a>\n");
            EndContext();
#line 11 "/home/briankernighan/IdeaProjects/Advert/Bazaar/Views/Shared/ProfilePartial.cshtml"
        }

#line default
#line hidden
            BeginContext(289, 11, true);
            WriteLiteral("    </div>\n");
            EndContext();
#line 13 "/home/briankernighan/IdeaProjects/Advert/Bazaar/Views/Shared/ProfilePartial.cshtml"

    if (string.IsNullOrEmpty(Model.ImagePath))
    {

#line default
#line hidden
            BeginContext(354, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(362, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2c64310b40a54b758e0256413a6f1b58", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(439, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 17 "/home/briankernighan/IdeaProjects/Advert/Bazaar/Views/Shared/ProfilePartial.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(461, 31, true);
            WriteLiteral("        <img id=\"profile-image\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 492, "\"", 514, 1);
#line 20 "/home/briankernighan/IdeaProjects/Advert/Bazaar/Views/Shared/ProfilePartial.cshtml"
WriteAttributeValue("", 498, Model.ImagePath, 498, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(515, 27, true);
            WriteLiteral(" class=\"team__img\" alt=\"\">\n");
            EndContext();
#line 21 "/home/briankernighan/IdeaProjects/Advert/Bazaar/Views/Shared/ProfilePartial.cshtml"
    }
    

#line default
#line hidden
            BeginContext(553, 28, true);
            WriteLiteral("    <div class=\"card-body\">\n");
            EndContext();
#line 24 "/home/briankernighan/IdeaProjects/Advert/Bazaar/Views/Shared/ProfilePartial.cshtml"
         if (Model != null)
        {

#line default
#line hidden
            BeginContext(619, 14, true);
            WriteLiteral("            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 633, "\"", 652, 2);
            WriteAttributeValue("", 640, "/", 640, 1, true);
#line 26 "/home/briankernighan/IdeaProjects/Advert/Bazaar/Views/Shared/ProfilePartial.cshtml"
WriteAttributeValue("", 641, Model.Name, 641, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(653, 41, true);
            WriteLiteral(">\n                <h5 class=\"card-title\">");
            EndContext();
            BeginContext(695, 10, false);
#line 27 "/home/briankernighan/IdeaProjects/Advert/Bazaar/Views/Shared/ProfilePartial.cshtml"
                                  Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(705, 23, true);
            WriteLiteral("</h5>\n            </a>\n");
            EndContext();
            BeginContext(741, 100, true);
            WriteLiteral("            <div style=\"border-bottom: 1px solid #d5d5d5; margin-bottom: 10px;\">\n            </div>\n");
            EndContext();
            BeginContext(854, 77, true);
            WriteLiteral("            <div id=\"profile-phone__number\" class=\"pl-4 row\">               \n");
            EndContext();
#line 34 "/home/briankernighan/IdeaProjects/Advert/Bazaar/Views/Shared/ProfilePartial.cshtml"
                 if (!string.IsNullOrEmpty(Model.CallingCode) && !string.IsNullOrWhiteSpace(Model.CallingCode) && !string.IsNullOrEmpty(Model.PhoneNumber) && !string.IsNullOrWhiteSpace(Model.PhoneNumber))
                {

#line default
#line hidden
            BeginContext(1154, 105, true);
            WriteLiteral("                    <span>\n                        <i class=\"zmdi zmdi-smartphone-iphone zmdi-hc-fw\"></i>");
            EndContext();
            BeginContext(1260, 17, false);
#line 37 "/home/briankernighan/IdeaProjects/Advert/Bazaar/Views/Shared/ProfilePartial.cshtml"
                                                                         Write(Model.CallingCode);

#line default
#line hidden
            EndContext();
            BeginContext(1277, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1279, 17, false);
#line 37 "/home/briankernighan/IdeaProjects/Advert/Bazaar/Views/Shared/ProfilePartial.cshtml"
                                                                                            Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1296, 29, true);
            WriteLiteral("\n                    </span>\n");
            EndContext();
#line 39 "/home/briankernighan/IdeaProjects/Advert/Bazaar/Views/Shared/ProfilePartial.cshtml"
                }

#line default
#line hidden
            BeginContext(1343, 77, true);
            WriteLiteral("            </div> \n            <div id=\"profile-location\" class=\"pl-4 row\">\n");
            EndContext();
#line 42 "/home/briankernighan/IdeaProjects/Advert/Bazaar/Views/Shared/ProfilePartial.cshtml"
                 if (!string.IsNullOrEmpty(Model.Location) && !string.IsNullOrWhiteSpace(Model.Location))
                {

#line default
#line hidden
            BeginContext(1544, 91, true);
            WriteLiteral("                    <span>\n                        <i class=\"zmdi zmdi-pin zmdi-hc-fw\"></i>");
            EndContext();
            BeginContext(1636, 14, false);
#line 45 "/home/briankernighan/IdeaProjects/Advert/Bazaar/Views/Shared/ProfilePartial.cshtml"
                                                           Write(Model.Location);

#line default
#line hidden
            EndContext();
            BeginContext(1650, 31, true);
            WriteLiteral("  \n                    </span>\n");
            EndContext();
#line 47 "/home/briankernighan/IdeaProjects/Advert/Bazaar/Views/Shared/ProfilePartial.cshtml"
                }

#line default
#line hidden
            BeginContext(1699, 176, true);
            WriteLiteral("            </div> \n            <div id=\"profile-joined__time\" class=\"pl-4 row\">\n                <span>\n                    <i class=\"zmdi zmdi-calendar zmdi-hc-fw\"></i>Joined ");
            EndContext();
            BeginContext(1876, 15, false);
#line 51 "/home/briankernighan/IdeaProjects/Advert/Bazaar/Views/Shared/ProfilePartial.cshtml"
                                                                   Write(Model.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(1891, 102, true);
            WriteLiteral("\n                </span>\n            </div> \n            <div id=\"profile-birthday\" class=\"pl-4 row\">\n");
            EndContext();
#line 55 "/home/briankernighan/IdeaProjects/Advert/Bazaar/Views/Shared/ProfilePartial.cshtml"
                 if (!string.IsNullOrEmpty(Model.Birthday) && !string.IsNullOrWhiteSpace(Model.Birthday))
                {

#line default
#line hidden
            BeginContext(2117, 109, true);
            WriteLiteral("                    <span>\n                        <i class=\"zmdi zmdi-brightness-5 zmdi-hc-fw\"></i>Birthday ");
            EndContext();
            BeginContext(2227, 14, false);
#line 58 "/home/briankernighan/IdeaProjects/Advert/Bazaar/Views/Shared/ProfilePartial.cshtml"
                                                                             Write(Model.Birthday);

#line default
#line hidden
            EndContext();
            BeginContext(2241, 29, true);
            WriteLiteral("\n                    </span>\n");
            EndContext();
#line 60 "/home/briankernighan/IdeaProjects/Advert/Bazaar/Views/Shared/ProfilePartial.cshtml"
                }

#line default
#line hidden
            BeginContext(2288, 19, true);
            WriteLiteral("            </div>\n");
            EndContext();
#line 62 "/home/briankernighan/IdeaProjects/Advert/Bazaar/Views/Shared/ProfilePartial.cshtml"
        }

#line default
#line hidden
            BeginContext(2317, 11, true);
            WriteLiteral("    </div>\n");
            EndContext();
#line 64 "/home/briankernighan/IdeaProjects/Advert/Bazaar/Views/Shared/ProfilePartial.cshtml"
}

#line default
#line hidden
            BeginContext(2330, 2, true);
            WriteLiteral("\n\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591