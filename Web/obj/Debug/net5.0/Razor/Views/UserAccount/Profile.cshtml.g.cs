#pragma checksum "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Views\UserAccount\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9505772ab3dd8b39c199aad9436313b52bb804a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserAccount_Profile), @"mvc.1.0.view", @"/Views/UserAccount/Profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9505772ab3dd8b39c199aad9436313b52bb804a", @"/Views/UserAccount/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_UserAccount_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.ViewModels.UserProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/UserProfile.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Views\UserAccount\Profile.cshtml"
  
ViewData["Title"] = "User Profile";
Layout = "~/Views/Shared/_Layout.cshtml";  

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d9505772ab3dd8b39c199aad9436313b52bb804a4153", async() => {
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
                WriteLiteral("  \r\n");
            }
            );
            WriteLiteral(@"
<div class=""container"">
    <div class=""main-body"">
    
          <!-- Breadcrumb -->
          <nav aria-label=""breadcrumb"" class=""main-breadcrumb"">
            <ol class=""breadcrumb"">
              <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
              <li class=""breadcrumb-item""><a href=""javascript:void(0)"">User</a></li>
              <li class=""breadcrumb-item active"" aria-current=""page"">User Profile</li>
            </ol>
          </nav>
          <!-- /Breadcrumb -->
    
          <div class=""row gutters-sm"">
            <div class=""col-md-4 mb-3"">
              <div class=""card"">
                <div class=""card-body"">
                  <div class=""d-flex flex-column align-items-center text-center"">
                    <img src=""https://bootdey.com/img/Content/avatar/avatar7.png"" alt=""Admin"" class=""rounded-circle"" width=""150"">
                    <div class=""mt-3"">
                      <h4>");
#nullable restore
#line 30 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Views\UserAccount\Profile.cshtml"
                     Write(Model.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                      <a");
            BeginWriteAttribute("href", " href=\"", 1225, "\"", 1286, 2);
            WriteAttributeValue("", 1232, "/UserAccount/EditProfile?username=", 1232, 34, true);
#nullable restore
#line 31 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Views\UserAccount\Profile.cshtml"
WriteAttributeValue("", 1266, Model.User.UserName, 1266, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"">Edit Profile</a>
                      <button class=""btn btn-outline-primary"">Message</button>
                    </div>
                  </div>
                </div>
              </div>
              <div class=""card mt-3"">
                <ul class=""list-group list-group-flush"">
                  <li class=""list-group-item d-flex justify-content-between align-items-center flex-wrap"">
                    <h6 class=""mb-0""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-instagram mr-2 icon-inline text-danger""><rect x=""2"" y=""2"" width=""20"" height=""20"" rx=""5"" ry=""5""></rect><path d=""M16 11.37A4 4 0 1 1 12.63 8 4 4 0 0 1 16 11.37z""></path><line x1=""17.5"" y1=""6.5"" x2=""17.51"" y2=""6.5""></line></svg>Instagram</h6>
                    <span class=""text-secondary"">");
#nullable restore
#line 41 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Views\UserAccount\Profile.cshtml"
                                            Write(Model.User.UserProfile.InstagramURL);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                  </li>
                  <li class=""list-group-item d-flex justify-content-between align-items-center flex-wrap"">
                    <h6 class=""mb-0""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-facebook mr-2 icon-inline text-primary""><path d=""M18 2h-3a5 5 0 0 0-5 5v3H7v4h3v8h4v-8h3l1-4h-4V7a1 1 0 0 1 1-1h3z""></path></svg>Facebook</h6>
                    <span class=""text-secondary"">");
#nullable restore
#line 45 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Views\UserAccount\Profile.cshtml"
                                            Write(Model.User.UserProfile.FacebookURL);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                  </li>
                </ul>
              </div>
            </div>
            <div class=""col-md-8"">
              <div class=""card mb-3"">
                <div class=""card-body"">
                  <div class=""row"">
                    <div class=""col-sm-3"">
                      <h6 class=""mb-0"">Full Name</h6>
                    </div>
                    <div class=""col-sm-9 text-secondary"">
                      ");
#nullable restore
#line 58 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Views\UserAccount\Profile.cshtml"
                 Write(Model.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 58 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Views\UserAccount\Profile.cshtml"
                                        Write(Model.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                  </div>
                  <hr>
                  <div class=""row"">
                    <div class=""col-sm-3"">
                      <h6 class=""mb-0"">Email</h6>
                    </div>
                    <div class=""col-sm-9 text-secondary"">
                      ");
#nullable restore
#line 67 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Views\UserAccount\Profile.cshtml"
                 Write(Model.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                  </div>
                  <hr>
                  <div class=""row"">
                    <div class=""col-sm-3"">
                      <h6 class=""mb-0"">Categories</h6>
                    </div>
                    <div class=""col-sm-9 text-secondary"">
                      
");
#nullable restore
#line 77 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Views\UserAccount\Profile.cshtml"
                       foreach (var cat in @Model.User.UserProfile.UserCategories)
                      {
                          

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Views\UserAccount\Profile.cshtml"
                     Write(cat.Category.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\gogag\OneDrive\Desktop\ArtyFact-Back\Web\Views\UserAccount\Profile.cshtml"
                                            
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                  </div>
                </div>
              </div>
              <div class=""row gutters-sm"">
                <div class=""col-sm-6 mb-3"">
                  <div class=""card h-100"">
                    <div class=""card-body"">
                      <h6 class=""d-flex align-items-center mb-3""><i class=""material-icons text-info mr-2"">assignment</i>Project Status</h6>
                      <small>Web Design</small>
                      <div class=""progress mb-3"" style=""height: 5px"">
                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 80%"" aria-valuenow=""80"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                      </div>
                      <small>Website Markup</small>
                      <div class=""progress mb-3"" style=""height: 5px"">
                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 72%"" aria-valuenow=""72"" aria-valuemin=""0"" aria-valuemax=""100""></div>
   ");
            WriteLiteral(@"                   </div>
                      <small>One Page</small>
                      <div class=""progress mb-3"" style=""height: 5px"">
                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 89%"" aria-valuenow=""89"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                      </div>
                      <small>Mobile Template</small>
                      <div class=""progress mb-3"" style=""height: 5px"">
                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 55%"" aria-valuenow=""55"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                      </div>
                      <small>Backend API</small>
                      <div class=""progress mb-3"" style=""height: 5px"">
                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 66%"" aria-valuenow=""66"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                      </div>
                    </div>
                  </div");
            WriteLiteral(@">
                </div>
                <div class=""col-sm-6 mb-3"">
                  <div class=""card h-100"">
                    <div class=""card-body"">
                      <h6 class=""d-flex align-items-center mb-3""><i class=""material-icons text-info mr-2"">assignment</i>Project Status</h6>
                      <small>Web Design</small>
                      <div class=""progress mb-3"" style=""height: 5px"">
                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 80%"" aria-valuenow=""80"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                      </div>
                      <small>Website Markup</small>
                      <div class=""progress mb-3"" style=""height: 5px"">
                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 72%"" aria-valuenow=""72"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                      </div>
                      <small>One Page</small>
                      <div class=""progress ");
            WriteLiteral(@"mb-3"" style=""height: 5px"">
                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 89%"" aria-valuenow=""89"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                      </div>
                      <small>Mobile Template</small>
                      <div class=""progress mb-3"" style=""height: 5px"">
                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 55%"" aria-valuenow=""55"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                      </div>
                      <small>Backend API</small>
                      <div class=""progress mb-3"" style=""height: 5px"">
                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 66%"" aria-valuenow=""66"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.ViewModels.UserProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
