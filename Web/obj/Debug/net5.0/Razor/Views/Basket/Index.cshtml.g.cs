#pragma checksum "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Views\Basket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a277da23c0a38547caa27a06fd006ba26420246"
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
#line 1 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a277da23c0a38547caa27a06fd006ba26420246", @"/Views/Basket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Basket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Domain.Entities.Basket.Basket>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("remove_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Basket/Remove"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("updatebutton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Views\Basket\Index.cshtml"
  
    ViewData["Title"] = "Basket";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n   \r\n    <link href=\"https://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css\" rel=\"stylesheet\">\r\n");
            }
            );
            WriteLiteral(@"        <div class=""container mt-2"">
            <div class=""wrapper wrapper-content animated fadeInRight"">
                <div class=""row"">
                    <div class=""col-md-9"">
                        <div class=""ibox"">
                            <div class=""ibox-title"">
                                <span class=""pull-right"">(<strong>");
#nullable restore
#line 18 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Views\Basket\Index.cshtml"
                                                             Write(Model.BasketItems.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>) items</span>\r\n                                <h5>Items in your cart</h5>\r\n                            </div>\r\n");
#nullable restore
#line 24 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Views\Basket\Index.cshtml"
                                 foreach (var item in @Model.BasketItems)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""ibox-content"">
                                    <div class=""table-responsive"">
                                        <table class=""table shoping-cart-table"">
                                            <tbody>
                                                <tr>
                                                    <td width=""90"">

                                                        <img src=""https://via.placeholder.com/150"" width=""90"">

                                                    </td>
                                                    <td class=""desc"">
                                                        <h3>
                                                            <a href=""#"" class=""text-navy"">
                                                                 ");
#nullable restore
#line 39 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Views\Basket\Index.cshtml"
                                                            Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                            </a>
                                                        </h3>
                                                        <p class=""small"">
                                                            It is a long established fact that a reader will be distracted by the readable
                                                            content of a page when looking at its layout. The point of using Lorem Ipsum is
                                                        </p>
                                                        <dl class=""small m-b-none"">
                                                            <dt>Description lists</dt>
                                                            <dd>A description list is perfect for defining terms.</dd>
                                                        </dl>

                                                        <div class=""m-t-sm"">
                                       ");
            WriteLiteral("                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a277da23c0a38547caa27a06fd006ba264202469849", async() => {
                WriteLiteral("\r\n                                                                <input type=\"hidden\" name=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 3181, "\"", 3204, 1);
#nullable restore
#line 53 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Views\Basket\Index.cshtml"
WriteAttributeValue("", 3189, item.ProductId, 3189, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                                                ");
#nullable restore
#line 54 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Views\Basket\Index.cshtml"
                                                           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                                <!-- Button trigger modal -->\r\n                                                                <button type=\"submit\"><i class=\"fa fa-trash\"></i> Remove item</button>\r\n");
                WriteLiteral("                                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                        </div>\r\n                                                    </td>\r\n\r\n                                                    <td>\r\n                                                        $");
#nullable restore
#line 63 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Views\Basket\Index.cshtml"
                                                    Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td width=\"85\">\r\n                                                        <input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 4222, "\"", 4229, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4230, "\"", 4238, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                        <input type=\"number\" class=\"form-control\" min=\"0\"");
            BeginWriteAttribute("name", " name=\"", 4349, "\"", 4356, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4357, "\"", 4365, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    </td>
                                                    
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>

                                </div>
");
#nullable restore
#line 76 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Views\Basket\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"ibox-content\">\r\n");
            WriteLiteral(@"                                <a href=""/"" class=""btn btn-white""><i class=""fa fa-arrow-left""></i> Continue shopping</a>
                                <a href=""/Basket/Checkout"" class=""btn btn-white float-right""><i class=""fa fa-arrow-right""></i> Checkout</a>

                            </div>
                        </div>

                    </div>
                    <div class=""col-md-3"">
                        <div class=""ibox"">
                            <div class=""ibox-title"">
                                <h5>Cart Summary</h5>
                            </div>
                            <div class=""ibox-content"">
                                <span>
                                    Total
                                </span>
                                <h2 class=""font-bold"">
                                    $  ");
            WriteLiteral(@"555
                                </h2>

                                <hr>
                                <span class=""text-muted small"">
                                    *For United States, France and Germany applicable sales tax will be applied
                                </span>
                                <div class=""m-t-sm"">
                                    <div class=""btn-group"">
");
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a277da23c0a38547caa27a06fd006ba2642024616065", async() => {
                WriteLiteral("\r\n                                            Update\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        <a href=""#"" class=""btn btn-danger btn-sm""> Cancel</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(\'#remove_button\').on(\'click\',function(){\r\n            console.log(\'clicked\');\r\n            $(\'#remove_form\')\r\n            .attr(\"action\", \'/Basket/Remove\')\r\n            .submit();\r\n        });\r\n    </script>\r\n");
            }
            );
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
