#pragma checksum "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\Agency\Agency\Areas\admin\Views\Shared\Components\Navbar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ef901f8a1f4192889f8d29e7624bc18a444a7fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_Shared_Components_Navbar_Default), @"mvc.1.0.view", @"/Areas/admin/Views/Shared/Components/Navbar/Default.cshtml")]
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
#line 3 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\Agency\Agency\Areas\admin\Views\_ViewImports.cshtml"
using Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\Agency\Agency\Areas\admin\Views\_ViewImports.cshtml"
using Agency.ViewModels.Product;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ef901f8a1f4192889f8d29e7624bc18a444a7fb", @"/Areas/admin/Views/Shared/Components/Navbar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ad9d5112f4405150dafe766e68033ec24ef116e", @"/Areas/admin/Views/_ViewImports.cshtml")]
    public class Areas_admin_Views_Shared_Components_Navbar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link mt-2 mt-md-0 d-none d-lg-flex search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""navbar p-0 fixed-top d-flex flex-row"">
    <div class=""navbar-brand-wrapper d-flex d-lg-none align-items-center justify-content-center"">
        <a class=""navbar-brand brand-logo-mini"" href=""index.html""><img src=""assets/images/logo-mini.svg"" alt=""logo"" /></a>
    </div>
    <div class=""navbar-menu-wrapper flex-grow d-flex align-items-stretch"">
        <button class=""navbar-toggler navbar-toggler align-self-center"" type=""button"" data-toggle=""minimize"">
            <span class=""mdi mdi-menu""></span>
        </button>
        <ul class=""navbar-nav w-100"">
            <li class=""nav-item w-100"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ef901f8a1f4192889f8d29e7624bc18a444a7fb4513", async() => {
                WriteLiteral("\r\n                    <input type=\"text\" class=\"form-control\" placeholder=\"Search products\">\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </li>
        </ul>
        <ul class=""navbar-nav navbar-nav-right"">
            <li class=""nav-item dropdown d-none d-lg-block"">
                <a class=""nav-link btn btn-success create-new-button"" id=""createbuttonDropdown"" data-bs-toggle=""dropdown"" aria-expanded=""false"" href=""#"">+ Create New Project</a>
                <div class=""dropdown-menu dropdown-menu-right navbar-dropdown preview-list"" aria-labelledby=""createbuttonDropdown"">
                    <h6 class=""p-3 mb-0"">Projects</h6>
                    <div class=""dropdown-divider""></div>
                    <a class=""dropdown-item preview-item"">
                        <div class=""preview-thumbnail"">
                            <div class=""preview-icon bg-dark rounded-circle"">
                                <i class=""mdi mdi-file-outline text-primary""></i>
                            </div>
                        </div>
                        <div class=""preview-item-content"">
                            <p class=""previ");
            WriteLiteral(@"ew-subject ellipsis mb-1"">Software Development</p>
                        </div>
                    </a>
                    <div class=""dropdown-divider""></div>
                    <a class=""dropdown-item preview-item"">
                        <div class=""preview-thumbnail"">
                            <div class=""preview-icon bg-dark rounded-circle"">
                                <i class=""mdi mdi-web text-info""></i>
                            </div>
                        </div>
                        <div class=""preview-item-content"">
                            <p class=""preview-subject ellipsis mb-1"">UI Development</p>
                        </div>
                    </a>
                    <div class=""dropdown-divider""></div>
                    <a class=""dropdown-item preview-item"">
                        <div class=""preview-thumbnail"">
                            <div class=""preview-icon bg-dark rounded-circle"">
                                <i class=""mdi mdi-layers tex");
            WriteLiteral(@"t-danger""></i>
                            </div>
                        </div>
                        <div class=""preview-item-content"">
                            <p class=""preview-subject ellipsis mb-1"">Software Testing</p>
                        </div>
                    </a>
                    <div class=""dropdown-divider""></div>
                    <p class=""p-3 mb-0 text-center"">See all projects</p>
                </div>
            </li>
            <li class=""nav-item nav-settings d-none d-lg-block"">
                <a class=""nav-link"" href=""#"">
                    <i class=""mdi mdi-view-grid""></i>
                </a>
            </li>
            <li class=""nav-item dropdown border-left"">
                <a class=""nav-link count-indicator dropdown-toggle"" id=""messageDropdown"" href=""#"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                    <i class=""mdi mdi-email""></i>
                    <span class=""count bg-success""></span>
                </a>
          ");
            WriteLiteral(@"      <div class=""dropdown-menu dropdown-menu-right navbar-dropdown preview-list"" aria-labelledby=""messageDropdown"">
                    <h6 class=""p-3 mb-0"">Messages</h6>
                    <div class=""dropdown-divider""></div>
                    <a class=""dropdown-item preview-item"">
                        <div class=""preview-thumbnail"">
                            <img src=""assets/images/faces/face4.jpg"" alt=""image"" class=""rounded-circle profile-pic"">
                        </div>
                        <div class=""preview-item-content"">
                            <p class=""preview-subject ellipsis mb-1"">Mark send you a message</p>
                            <p class=""text-muted mb-0""> 1 Minutes ago </p>
                        </div>
                    </a>
                    <div class=""dropdown-divider""></div>
                    <a class=""dropdown-item preview-item"">
                        <div class=""preview-thumbnail"">
                            <img src=""assets/images/faces/");
            WriteLiteral(@"face2.jpg"" alt=""image"" class=""rounded-circle profile-pic"">
                        </div>
                        <div class=""preview-item-content"">
                            <p class=""preview-subject ellipsis mb-1"">Cregh send you a message</p>
                            <p class=""text-muted mb-0""> 15 Minutes ago </p>
                        </div>
                    </a>
                    <div class=""dropdown-divider""></div>
                    <a class=""dropdown-item preview-item"">
                        <div class=""preview-thumbnail"">
                            <img src=""assets/images/faces/face3.jpg"" alt=""image"" class=""rounded-circle profile-pic"">
                        </div>
                        <div class=""preview-item-content"">
                            <p class=""preview-subject ellipsis mb-1"">Profile picture updated</p>
                            <p class=""text-muted mb-0""> 18 Minutes ago </p>
                        </div>
                    </a>
                    ");
            WriteLiteral(@"<div class=""dropdown-divider""></div>
                    <p class=""p-3 mb-0 text-center"">4 new messages</p>
                </div>
            </li>
            <li class=""nav-item dropdown border-left"">
                <a class=""nav-link count-indicator dropdown-toggle"" id=""notificationDropdown"" href=""#"" data-bs-toggle=""dropdown"">
                    <i class=""mdi mdi-bell""></i>
                    <span class=""count bg-danger""></span>
                </a>
                <div class=""dropdown-menu dropdown-menu-right navbar-dropdown preview-list"" aria-labelledby=""notificationDropdown"">
                    <h6 class=""p-3 mb-0"">Notifications</h6>
                    <div class=""dropdown-divider""></div>
                    <a class=""dropdown-item preview-item"">
                        <div class=""preview-thumbnail"">
                            <div class=""preview-icon bg-dark rounded-circle"">
                                <i class=""mdi mdi-calendar text-success""></i>
                          ");
            WriteLiteral(@"  </div>
                        </div>
                        <div class=""preview-item-content"">
                            <p class=""preview-subject mb-1"">Event today</p>
                            <p class=""text-muted ellipsis mb-0""> Just a reminder that you have an event today </p>
                        </div>
                    </a>
                    <div class=""dropdown-divider""></div>
                    <a class=""dropdown-item preview-item"">
                        <div class=""preview-thumbnail"">
                            <div class=""preview-icon bg-dark rounded-circle"">
                                <i class=""mdi mdi-settings text-danger""></i>
                            </div>
                        </div>
                        <div class=""preview-item-content"">
                            <p class=""preview-subject mb-1"">Settings</p>
                            <p class=""text-muted ellipsis mb-0""> Update dashboard </p>
                        </div>
                 ");
            WriteLiteral(@"   </a>
                    <div class=""dropdown-divider""></div>
                    <a class=""dropdown-item preview-item"">
                        <div class=""preview-thumbnail"">
                            <div class=""preview-icon bg-dark rounded-circle"">
                                <i class=""mdi mdi-link-variant text-warning""></i>
                            </div>
                        </div>
                        <div class=""preview-item-content"">
                            <p class=""preview-subject mb-1"">Launch Admin</p>
                            <p class=""text-muted ellipsis mb-0""> New admin wow! </p>
                        </div>
                    </a>
                    <div class=""dropdown-divider""></div>
                    <p class=""p-3 mb-0 text-center"">See all notifications</p>
                </div>
            </li>
            <li class=""nav-item dropdown"">
                <a class=""nav-link"" id=""profileDropdown"" href=""#"" data-bs-toggle=""dropdown"">
          ");
            WriteLiteral("          <div class=\"navbar-profile\">\r\n                        <img class=\"img-xs rounded-circle\" src=\"assets/images/faces/face15.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 9141, "\"", 9147, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <p class=""mb-0 d-none d-sm-block navbar-profile-name"">Henry Klein</p>
                        <i class=""mdi mdi-menu-down d-none d-sm-block""></i>
                    </div>
                </a>
                <div class=""dropdown-menu dropdown-menu-right navbar-dropdown preview-list"" aria-labelledby=""profileDropdown"">
                    <h6 class=""p-3 mb-0"">Profile</h6>
                    <div class=""dropdown-divider""></div>
                    <a class=""dropdown-item preview-item"">
                        <div class=""preview-thumbnail"">
                            <div class=""preview-icon bg-dark rounded-circle"">
                                <i class=""mdi mdi-settings text-success""></i>
                            </div>
                        </div>
                        <div class=""preview-item-content"">
                            <p class=""preview-subject mb-1"">Settings</p>
                        </div>
                    </a>
                    <di");
            WriteLiteral(@"v class=""dropdown-divider""></div>
                    <a class=""dropdown-item preview-item"">
                        <div class=""preview-thumbnail"">
                            <div class=""preview-icon bg-dark rounded-circle"">
                                <i class=""mdi mdi-logout text-danger""></i>
                            </div>
                        </div>
                        <div class=""preview-item-content"">
                            <p class=""preview-subject mb-1"">Log out</p>
                        </div>
                    </a>
                    <div class=""dropdown-divider""></div>
                    <p class=""p-3 mb-0 text-center"">Advanced settings</p>
                </div>
            </li>
        </ul>
        <button class=""navbar-toggler navbar-toggler-right d-lg-none align-self-center"" type=""button"" data-toggle=""offcanvas"">
            <span class=""mdi mdi-format-line-spacing""></span>
        </button>
    </div>
</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
