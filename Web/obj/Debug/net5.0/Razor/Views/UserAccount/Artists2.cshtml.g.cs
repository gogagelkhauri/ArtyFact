#pragma checksum "E:\ArtyFact-Back\Web\Views\UserAccount\Artists2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5658c2cd78a59a012e591d7508b78cbb5bdb6a7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserAccount_Artists2), @"mvc.1.0.view", @"/Views/UserAccount/Artists2.cshtml")]
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
#line 1 "E:\ArtyFact-Back\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ArtyFact-Back\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5658c2cd78a59a012e591d7508b78cbb5bdb6a7a", @"/Views/UserAccount/Artists2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_UserAccount_Artists2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Domain.Entities.User.ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Front/artist.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/octane.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("rover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "E:\ArtyFact-Back\Web\Views\UserAccount\Artists2.cshtml"
    
    ViewData["Title"] = "Artists";  
    Layout = "~/Views/Shared/_Layout2.cshtml";  

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5658c2cd78a59a012e591d7508b78cbb5bdb6a7a4756", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("<div class=\"container1\">\r\n");
#nullable restore
#line 11 "E:\ArtyFact-Back\Web\Views\UserAccount\Artists2.cshtml"
     foreach (var item in Model)
    {
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 350, "\"", 401, 2);
            WriteAttributeValue("", 357, "/UserAccount/Profile?userName=", 357, 30, true);
#nullable restore
#line 15 "E:\ArtyFact-Back\Web\Views\UserAccount\Artists2.cshtml"
WriteAttributeValue("", 387, item.UserName, 387, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"card-header\">\r\n");
#nullable restore
#line 17 "E:\ArtyFact-Back\Web\Views\UserAccount\Artists2.cshtml"
                 if(item.UserProfile.Image != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img");
            BeginWriteAttribute("src", " src=\"", 540, "\"", 569, 1);
#nullable restore
#line 19 "E:\ArtyFact-Back\Web\Views\UserAccount\Artists2.cshtml"
WriteAttributeValue("", 546, item.UserProfile.Image, 546, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"rover\" />\r\n");
#nullable restore
#line 20 "E:\ArtyFact-Back\Web\Views\UserAccount\Artists2.cshtml"
                }
                else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5658c2cd78a59a012e591d7508b78cbb5bdb6a7a7615", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 23 "E:\ArtyFact-Back\Web\Views\UserAccount\Artists2.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            </a>\r\n            <div class=\"card-body\">\r\n");
#nullable restore
#line 27 "E:\ArtyFact-Back\Web\Views\UserAccount\Artists2.cshtml"
                 foreach (var cat in item.UserProfile.UserCategories)
                {   

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"tag tag-teal\">");
#nullable restore
#line 29 "E:\ArtyFact-Back\Web\Views\UserAccount\Artists2.cshtml"
                                          Write(cat.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n");
#nullable restore
#line 30 "E:\ArtyFact-Back\Web\Views\UserAccount\Artists2.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"user\">\r\n                <div class=\"user-info\">\r\n                <h5>");
#nullable restore
#line 33 "E:\ArtyFact-Back\Web\Views\UserAccount\Artists2.cshtml"
               Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                </div>\r\n            </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 38 "E:\ArtyFact-Back\Web\Views\UserAccount\Artists2.cshtml"
        
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Domain.Entities.User.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
