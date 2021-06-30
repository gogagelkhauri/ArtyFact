#pragma checksum "E:\ArtyFact-Back\Web\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c8c001b2903f930123e457532463ed4af390905"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c8c001b2903f930123e457532463ed4af390905", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Domain.Entities.Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Front/artist.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\ArtyFact-Back\Web\Views\Category\Index.cshtml"
    
    ViewData["Title"] = "Categories";  
    Layout = "~/Views/Shared/_blogLayout.cshtml";  

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7c8c001b2903f930123e457532463ed4af3909054017", async() => {
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
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("    <div class=\"section--title\">\r\n        <h2>Categories</h2>\r\n    </div>\r\n\r\n    <section>\r\n        <div class=\"artists--wrapper\">\r\n");
#nullable restore
#line 16 "E:\ArtyFact-Back\Web\Views\Category\Index.cshtml"
             if(Model.Count() > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\ArtyFact-Back\Web\Views\Category\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"artist--content\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 558, "\"", 578, 1);
#nullable restore
#line 21 "E:\ArtyFact-Back\Web\Views\Category\Index.cshtml"
WriteAttributeValue("", 564, item.ImageURL, 564, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"rover\" style=\"width: 300px; height: 400px; object-fit: cover; border-radius: 1rem;\" />\r\n                \r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 721, "\"", 765, 2);
            WriteAttributeValue("", 728, "/product/products?category=", 728, 27, true);
#nullable restore
#line 23 "E:\ArtyFact-Back\Web\Views\Category\Index.cshtml"
WriteAttributeValue("", 755, item.Name, 755, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 23 "E:\ArtyFact-Back\Web\Views\Category\Index.cshtml"
                                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                    </div>\r\n");
#nullable restore
#line 25 "E:\ArtyFact-Back\Web\Views\Category\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\ArtyFact-Back\Web\Views\Category\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Domain.Entities.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
