#pragma checksum "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Areas\Identity\Views\Account\register2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32e35012ca3bcf741a1166d521b642da6c33150e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Views_Account_register2), @"mvc.1.0.view", @"/Areas/Identity/Views/Account/register2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32e35012ca3bcf741a1166d521b642da6c33150e", @"/Areas/Identity/Views/Account/register2.cshtml")]
    public class Areas_Identity_Views_Account_register2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Areas.Identity.ViewModels.RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Areas\Identity\Views\Account\register2.cshtml"
    
    ViewData["Title"] = "Register";  
    Layout = "~/Views/Shared/_Layout.cshtml";  

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">  \r\n    <h1>Register</h1> \r\n    <form action=\"/Identity/Account/Register\" method=\"post\">  \r\n  \r\n        <div class=\"registerdiv\">  \r\n            <div class=\"form-group col-sm-12\">  \r\n                <label");
            BeginWriteAttribute("asp-for", " asp-for=\"", 385, "\"", 411, 1);
#nullable restore
#line 12 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Areas\Identity\Views\Account\register2.cshtml"
WriteAttributeValue("", 395, Model.FirstName, 395, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"col-lg-3 control-label\">First Name</label>  \r\n                <br>  \r\n                <div class=\"col-lg-9\">  \r\n                    ");
#nullable restore
#line 15 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Areas\Identity\Views\Account\register2.cshtml"
               Write(Html.TextBoxFor(m => m.FirstName, new { placeholder = "", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n                    ");
#nullable restore
#line 16 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Areas\Identity\Views\Account\register2.cshtml"
               Write(Html.ValidationMessageFor(m => m.FirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n                </div>  \r\n            </div>  \r\n\r\n            <div class=\"form-group col-sm-12\">  \r\n                <label");
            BeginWriteAttribute("asp-for", " asp-for=\"", 867, "\"", 892, 1);
#nullable restore
#line 21 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Areas\Identity\Views\Account\register2.cshtml"
WriteAttributeValue("", 877, Model.LastName, 877, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"col-lg-3 control-label\">Last Name</label>  \r\n                <br>  \r\n                <div class=\"col-lg-9\">  \r\n                    ");
#nullable restore
#line 24 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Areas\Identity\Views\Account\register2.cshtml"
               Write(Html.TextBoxFor(m => m.LastName, new { placeholder = "", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n                    ");
#nullable restore
#line 25 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Areas\Identity\Views\Account\register2.cshtml"
               Write(Html.ValidationMessageFor(m => m.LastName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n                </div>  \r\n            </div>  \r\n             <div class=\"form-group col-sm-12\">  \r\n                <label");
            BeginWriteAttribute("asp-for", " asp-for=\"", 1344, "\"", 1369, 1);
#nullable restore
#line 29 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Areas\Identity\Views\Account\register2.cshtml"
WriteAttributeValue("", 1354, Model.UserName, 1354, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"col-lg-3 control-label\">UserName</label>  \r\n                <br>  \r\n                <div class=\"col-lg-9\">  \r\n                    ");
#nullable restore
#line 32 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Areas\Identity\Views\Account\register2.cshtml"
               Write(Html.TextBoxFor(m => m.UserName, new { placeholder = "", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n                    ");
#nullable restore
#line 33 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Areas\Identity\Views\Account\register2.cshtml"
               Write(Html.ValidationMessageFor(m => m.UserName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n                </div>  \r\n            </div>  \r\n  \r\n  \r\n            <div class=\"form-group col-sm-12\">  \r\n                <label");
            BeginWriteAttribute("asp-for", " asp-for=\"", 1827, "\"", 1849, 1);
#nullable restore
#line 39 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Areas\Identity\Views\Account\register2.cshtml"
WriteAttributeValue("", 1837, Model.Email, 1837, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"col-lg-3 control-label\">Email</label>  \r\n                <br>  \r\n                <div class=\"col-lg-9\">  \r\n                    ");
#nullable restore
#line 42 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Areas\Identity\Views\Account\register2.cshtml"
               Write(Html.TextBoxFor(m => m.Email, new { placeholder = "", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n                    ");
#nullable restore
#line 43 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Areas\Identity\Views\Account\register2.cshtml"
               Write(Html.ValidationMessageFor(m => m.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n                </div>  \r\n            </div>  \r\n  \r\n            <div class=\"form-group col-sm-12\">  \r\n                <label");
            BeginWriteAttribute("asp-for", " asp-for=\"", 2294, "\"", 2319, 1);
#nullable restore
#line 48 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Areas\Identity\Views\Account\register2.cshtml"
WriteAttributeValue("", 2304, Model.Password, 2304, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"col-lg-3 control-label\">Password</label>  \r\n                <br>  \r\n                <div class=\"col-lg-9\">  \r\n                    ");
#nullable restore
#line 51 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Areas\Identity\Views\Account\register2.cshtml"
               Write(Html.PasswordFor(m => m.Password, new { placeholder = "", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n                    ");
#nullable restore
#line 52 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Areas\Identity\Views\Account\register2.cshtml"
               Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n                </div>  \r\n            </div>  \r\n  \r\n            <div class=\"form-group col-sm-12\">  \r\n                <label");
            BeginWriteAttribute("asp-for", " asp-for=\"", 2774, "\"", 2806, 1);
#nullable restore
#line 57 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Areas\Identity\Views\Account\register2.cshtml"
WriteAttributeValue("", 2784, Model.ConfirmPassword, 2784, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"col-lg-3 control-label\">Confirm Password</label>  \r\n                <br>  \r\n                <div class=\"col-lg-9\">  \r\n                    ");
#nullable restore
#line 60 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Areas\Identity\Views\Account\register2.cshtml"
               Write(Html.PasswordFor(m => m.ConfirmPassword, new { placeholder = "", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n                    ");
#nullable restore
#line 61 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Areas\Identity\Views\Account\register2.cshtml"
               Write(Html.ValidationMessageFor(m => m.ConfirmPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  
                </div>  
            </div>  
  
            <div class=""form-group"">  
                <div class=""col-sm-12 btn-submit"">  
                    <button type=""submit"" class=""btn btn-success"">Sign Up</button>  
                </div>  
            </div>  
        </div>  
    </form>  
</div>  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Areas.Identity.ViewModels.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
