#pragma checksum "E:\ArtyFact-Back\Web\Views\Basket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87726c6e3e44ba5d1f7440ed5eeb90c30d6e30f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Index), @"mvc.1.0.view", @"/Views/Basket/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87726c6e3e44ba5d1f7440ed5eeb90c30d6e30f8", @"/Views/Basket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Basket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Domain.Entities.Basket.Basket>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Front/cart.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("logoutForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Identity/Account/Logout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Basket/Remove"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\ArtyFact-Back\Web\Views\Basket\Index.cshtml"
  
    ViewData["Title"] = "Basket";
    Layout = "";
    //Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87726c6e3e44ba5d1f7440ed5eeb90c30d6e30f86202", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Cart</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "87726c6e3e44ba5d1f7440ed5eeb90c30d6e30f86670", async() => {
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
                WriteLiteral("\r\n    <link href=\"https://fonts.googleapis.com/css2?family=Quicksand:wght@300;400;600&display=swap\" rel=\"stylesheet\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87726c6e3e44ba5d1f7440ed5eeb90c30d6e30f88676", async() => {
                WriteLiteral(@"
    <header>
        <div class=""header--container"">
            <div class=""logo--container"">
                <a href=""/"">
                    <svg width=""50"" height=""47"" viewBox=""0 0 50 47"" fill=""red"" xmlns=""http://www.w3.org/2000/svg"">
                        <path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M29.1601 2.92698C27.2758 -0.594311 22.2273 -0.594312 20.3431 2.92698L0.81637 39.418C-1.44009 43.6348 2.94287 48.309 7.29591 46.328L22.6805 39.3267C23.9963 38.728 25.5068 38.728 26.8226 39.3267L42.2072 46.328C46.5602 48.309 50.9432 43.6349 48.6868 39.418L29.1601 2.92698ZM22.4804 31.0601C23.4898 32.8084 26.0133 32.8084 27.0227 31.0601L31.4109 23.4595C32.6866 21.2499 30.3757 18.7045 28.0535 19.7613L25.8378 20.7696C25.1477 21.0837 24.3554 21.0837 23.6653 20.7696L21.4496 19.7613C19.1273 18.7045 16.8165 21.2499 18.0922 23.4595L22.4804 31.0601Z"" fill=""rgb(32, 32, 32)""/>
                    </svg>  
                </a>    
            </div>
            <nav>
                <ul>
                 ");
                WriteLiteral("   <li><a href=\"/UserAccount/Artists\">Artists</a></li>\r\n                    <li><a");
                BeginWriteAttribute("href", " href=\"", 1673, "\"", 1729, 2);
                WriteAttributeValue("", 1680, "/UserAccount/Profile?userName=", 1680, 30, true);
#nullable restore
#line 30 "E:\ArtyFact-Back\Web\Views\Basket\Index.cshtml"
WriteAttributeValue("", 1710, User.Identity.Name, 1710, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Profile</a></li>\r\n                    <li>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87726c6e3e44ba5d1f7440ed5eeb90c30d6e30f810620", async() => {
                    WriteLiteral("\r\n                            <a onclick=\"document.getElementById(\'logoutForm\').submit();\" style=\"cursor: pointer\">Logout</a>\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </li>\r\n                </ul>\r\n            </nav>\r\n        </div>\r\n    </header>\r\n\r\n    <section style=\"min-height:550px\">\r\n");
#nullable restore
#line 42 "E:\ArtyFact-Back\Web\Views\Basket\Index.cshtml"
         if(@Model.BasketItems.Count > 0)
        {

       

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"cart--wrapper\">\r\n            <div class=\"cart--items__list\">\r\n\r\n                <div class=\"cart--items__title\">\r\n                    <h1>Your Cart (");
#nullable restore
#line 50 "E:\ArtyFact-Back\Web\Views\Basket\Index.cshtml"
                              Write(Model.BasketItems.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral(")</h1>\r\n                </div>\r\n");
#nullable restore
#line 52 "E:\ArtyFact-Back\Web\Views\Basket\Index.cshtml"
                 foreach (var item in @Model.BasketItems)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"cart--items\">\r\n                        <div class=\"product--description\">\r\n                            <div class=\"cart--item__image\"  >\r\n                                <img width=\"200px\" height=\"200px\"");
                BeginWriteAttribute("src", "  src=\"", 2775, "\"", 2804, 1);
#nullable restore
#line 57 "E:\ArtyFact-Back\Web\Views\Basket\Index.cshtml"
WriteAttributeValue("", 2782, item.Product.ImageURL, 2782, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"product1\">\r\n                            </div>\r\n                                \r\n                            <div class=\"cart--item__details\">\r\n                                <h2>");
#nullable restore
#line 61 "E:\ArtyFact-Back\Web\Views\Basket\Index.cshtml"
                               Write(item.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                                <p>Description: ");
#nullable restore
#line 62 "E:\ArtyFact-Back\Web\Views\Basket\Index.cshtml"
                                           Write(Html.Raw(@item.Product.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <p class=\"price\">");
#nullable restore
#line 63 "E:\ArtyFact-Back\Web\Views\Basket\Index.cshtml"
                                            Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" GEL</p>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87726c6e3e44ba5d1f7440ed5eeb90c30d6e30f815188", async() => {
                    WriteLiteral("\r\n                                        <input type=\"hidden\" name=\"productId\"");
                    BeginWriteAttribute("value", " value=\"", 3332, "\"", 3355, 1);
#nullable restore
#line 65 "E:\ArtyFact-Back\Web\Views\Basket\Index.cshtml"
WriteAttributeValue("", 3340, item.ProductId, 3340, 15, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                                        ");
#nullable restore
#line 66 "E:\ArtyFact-Back\Web\Views\Basket\Index.cshtml"
                                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                        <!-- Button trigger modal -->\r\n                                        <button type=\"submit\">Remove</button>\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                \r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 74 "E:\ArtyFact-Back\Web\Views\Basket\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

            </div>
    
            <div class=""cart--summary__wrapper"">
                <div class=""cart--summary"">
                    <div class=""cart--summary__title"">
                        <h2>Summary</h2>
                    </div>

                    <div class=""cart--summary__content"">
                        <h2>TOTAL: ");
#nullable restore
#line 86 "E:\ArtyFact-Back\Web\Views\Basket\Index.cshtml"
                              Write(Model.GetTotal());

#line default
#line hidden
#nullable disable
                WriteLiteral(@" GEL</h2>
                        <div class=""checkout--button"">
                            <a href=""/Order/CustomerInformation"">Checkout</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
");
#nullable restore
#line 94 "E:\ArtyFact-Back\Web\Views\Basket\Index.cshtml"
         }
         else
         {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <h1 style=\"text-align: center;\">There is no tems in your cart</h1>\r\n");
#nullable restore
#line 98 "E:\ArtyFact-Back\Web\Views\Basket\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    </section>

    <footer >
        <div class=""footer--container"">
            <div class=""footer--title"" >
                <img src=""../img/logo.svg"" alt=""footerLogo"">
                <h1>Artifact</h1>
            </div>

           
        </div>
    </footer>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Domain.Entities.Basket.Basket> Html { get; private set; }
    }
}
#pragma warning restore 1591
