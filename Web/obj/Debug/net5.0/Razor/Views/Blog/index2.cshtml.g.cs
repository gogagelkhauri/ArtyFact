#pragma checksum "D:\work\.netCore\end\ArtyFact-Back\Web\Views\Blog\index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff08091d7c976c63d7ad642d4d9822afb4d49acc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_index2), @"mvc.1.0.view", @"/Views/Blog/index2.cshtml")]
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
#line 1 "D:\work\.netCore\end\ArtyFact-Back\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\work\.netCore\end\ArtyFact-Back\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff08091d7c976c63d7ad642d4d9822afb4d49acc", @"/Views/Blog/index2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Domain.Entities.Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\work\.netCore\end\ArtyFact-Back\Web\Views\Blog\index2.cshtml"
  
    ViewData["Title"] = "Posts";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container"">
    <table class=""table table-striped table-dark"">
        <thead>
            <tr>
                <th scope=""col"">Id</th>
                <th scope=""col"">Title</th>
                <th scope=""col"">Image</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 18 "D:\work\.netCore\end\ArtyFact-Back\Web\Views\Blog\index2.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 21 "D:\work\.netCore\end\ArtyFact-Back\Web\Views\Blog\index2.cshtml"
                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 578, "\"", 604, 2);
            WriteAttributeValue("", 585, "/Blog/Post/", 585, 11, true);
#nullable restore
#line 22 "D:\work\.netCore\end\ArtyFact-Back\Web\Views\Blog\index2.cshtml"
WriteAttributeValue("", 596, item.Id, 596, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "D:\work\.netCore\end\ArtyFact-Back\Web\Views\Blog\index2.cshtml"
                                                 Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                    <td>\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 682, "\"", 702, 1);
#nullable restore
#line 24 "D:\work\.netCore\end\ArtyFact-Back\Web\Views\Blog\index2.cshtml"
WriteAttributeValue("", 688, item.ImageURL, 688, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px\"; height:100px\" />\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 27 "D:\work\.netCore\end\ArtyFact-Back\Web\Views\Blog\index2.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Domain.Entities.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591