#pragma checksum "C:\Users\Huseyn\Desktop\Black Mesa HRMS\Black Mesa HRMS\Views\Department\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3862dea9dd142f16fc8249fef3bc4381d528ccae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Index), @"mvc.1.0.view", @"/Views/Department/Index.cshtml")]
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
#line 1 "C:\Users\Huseyn\Desktop\Black Mesa HRMS\Black Mesa HRMS\Views\_ViewImports.cshtml"
using Black_Mesa_HRMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Huseyn\Desktop\Black Mesa HRMS\Black Mesa HRMS\Views\_ViewImports.cshtml"
using Black_Mesa_HRMS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Huseyn\Desktop\Black Mesa HRMS\Black Mesa HRMS\Views\_ViewImports.cshtml"
using Black_Mesa_HRMS.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Huseyn\Desktop\Black Mesa HRMS\Black Mesa HRMS\Views\_ViewImports.cshtml"
using Black_Mesa_HRMS.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Huseyn\Desktop\Black Mesa HRMS\Black Mesa HRMS\Views\_ViewImports.cshtml"
using Black_Mesa_HRMS.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Huseyn\Desktop\Black Mesa HRMS\Black Mesa HRMS\Views\_ViewImports.cshtml"
using Black_Mesa_HRMS.TableModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3862dea9dd142f16fc8249fef3bc4381d528ccae", @"/Views/Department/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fe1df6659c61c552ab18391c47327a214c21cfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Department_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\Huseyn\Desktop\Black Mesa HRMS\Black Mesa HRMS\Views\Department\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<section id=\"Departments\">\n    <div class=\"Departments-con\">\n        <div class=\"Departments-top-con\">\n            <span>Departments</span>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3862dea9dd142f16fc8249fef3bc4381d528ccae4792", async() => {
                WriteLiteral("\n                <input class=\" form-control me-2\" type=\"search\" placeholder=\"Name or ID\" aria-label=\"Search\">\n                <button class=\"btn\" type=\"submit\">Search<i class=\"fa-solid fa-magnifying-glass\"></i></button>\n            ");
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
        </div>
        <div class=""Department-card-con"">
            <div class=""row"">
                <div class=""card-con  col-md-12 col-xxl-6"">
                    <div class=""card "">
                        <div class=""row g-0"">
                            <div class=""col-12"">
                                <img src=""./image/Hazard_Course.jpg"" class=""img-fluid rounded-top"" alt=""department image"">
                            </div>
                            <div class=""col-12"">
                                <div class=""card-body"">
                                    <h5 class=""card-title"">Sector A Training Facility</h5>
                                    <p class=""card-desc"">ector A contains the separate Hazard Courses used for training scientists, predominantly to the use of the HEV Suit and security guards</p>
                                    <p class=""card-text""><span class=""header"">Head of Staff : </span>Gordon Freeman</p>
                                    <p class=""card-text""><span class=""");
            WriteLiteral(@"header"">Employee Count : </span>999</p>
                                    <p class=""card-text""><span class=""header"">Avg. Salary : </span>999 $</p>
                                    <p class=""card-text""><span class=""header"">Total Salary : </span>999 $</p>
                                </div>
                                <div class=""card-footer"">
                                    <a href=""#"" type=""button"">All Department Employees <i class=""fa-solid fa-angles-right""></i></a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card-con col-md-12 col-xxl-6"">
                    <div class=""card "">
                        <div class=""row g-0"">
                            <div class=""col-12"">
                                <img src=""./image/sectorB.jfif"" class=""img-fluid rounded-top"" alt=""department image"">
                            </div>
                            <div c");
            WriteLiteral(@"lass=""col-12"">
                                <div class=""card-body"">
                                    <h5 class=""card-title"">Sector B Coolant Reserve</h5>
                                    <p class=""card-text"">The Coolant Reserve stores the industrial coolant used to maintain Black Mesa's thousands of computers and machines.</p>
                                    <p class=""card-text""><span class=""header"">Head of Staff : </span>Randy Pitchford</p>
                                    <p class=""card-text""><span class=""header"">Employee Count : </span>999</p>
                                    <p class=""card-text""><span class=""header"">Avg. Salary : </span>999</p>
                                    <p class=""card-text""><span class=""header"">Total Salary : </span>999</p>
                                </div>
                            </div>
                            <div class=""card-footer"">
                                <a href=""#"" type=""button"">All Department Employees <i class=""fa-solid fa-angles-");
            WriteLiteral(@"right""></i></a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card-con  col-md-12 col-xxl-6"">
                    <div class=""card "">
                        <div class=""row g-0"">
                            <div class=""col-12"">
                                <img src=""./image/Hazard_Course.jpg"" class=""img-fluid rounded-top"" alt=""department image"">
                            </div>
                            <div class=""col-12"">
                                <div class=""card-body"">
                                    <h5 class=""card-title"">Sector A Training Facility</h5>
                                    <p class=""card-text"">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                                    <p class=""card-text""><span class=""header"">Head of Staff : </span>Gordon Freeman</p>
                                 ");
            WriteLiteral(@"   <p class=""card-text""><span class=""header"">Employee Count : </span>999</p>
                                    <p class=""card-text""><span class=""header"">Avg. Salary : </span>999</p>
                                    <p class=""card-text""><span class=""header"">Total Salary : </span>999</p>
                                </div>
                            </div>
                            <div class=""card-footer"">
                                <a href=""#"" type=""button"">All Department Employees <i class=""fa-solid fa-angles-right""></i></a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card-con  col-md-12 col-xxl-6"">
                    <div class=""card "">
                        <div class=""row g-0"">
                            <div class=""col-12"">
                                <img src=""./image/Hazard_Course.jpg"" class=""img-fluid rounded-top"" alt=""department image"">
                            </div>
       ");
            WriteLiteral(@"                     <div class=""col-12"">
                                <div class=""card-body"">
                                    <h5 class=""card-title"">Sector A Training Facility</h5>
                                    <p class=""card-text"">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                                    <p class=""card-text""><span class=""header"">Head of Staff : </span>Gordon Freeman</p>
                                    <p class=""card-text""><span class=""header"">Employee Count : </span>999</p>
                                    <p class=""card-text""><span class=""header"">Avg. Salary : </span>999</p>
                                    <p class=""card-text""><span class=""header"">Total Salary : </span>999</p>
                                </div>
                            </div>
                            <div class=""card-footer"">
                                <a href=""#"" type=""button"">All Department");
            WriteLiteral(" Employees <i class=\"fa-solid fa-angles-right\"></i></a>\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</section>\n\n");
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
