#pragma checksum "C:\Users\Huseyn\Desktop\Black Mesa HRMS\Black Mesa HRMS\Views\LeaveRequest\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96cbf43df87c749ba7e19a38e9824d91dbde6d42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LeaveRequest_Index), @"mvc.1.0.view", @"/Views/LeaveRequest/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96cbf43df87c749ba7e19a38e9824d91dbde6d42", @"/Views/LeaveRequest/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fe1df6659c61c552ab18391c47327a214c21cfa", @"/Views/_ViewImports.cshtml")]
    public class Views_LeaveRequest_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("FormLeaveRequest"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Huseyn\Desktop\Black Mesa HRMS\Black Mesa HRMS\Views\LeaveRequest\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""LeaveRequest"">
    <div class=""leave-request-con"">
        <div class=""leave-request-top-con"">
            <span>Leave Requests</span>
        </div>
        <ul class=""list-group"">
            <li class=""list-group-item"">
                <div class=""list-item-top"">
                    <div>
                        Gordon Freeman
                    </div>
                    <div class=""list-item-btn-con"">
                        <button class=""btn btn-danger"" data-bs-toggle=""modal"" data-bs-target=""#LeaveRequestModal"">Deny<i class=""fa-solid fa-hand""></i></button>
                        <button class=""btn btn-success"">Allow<i class=""fa-solid fa-thumbs-up""></i> </button>
                    </div>
                </div>
                <div class=""list-item-title"">
                    <span>Lorem ipsum dolor sit amet consectetur adipisicing elit. Quis dolorem, dolores inventore quidem quas ducimus mollitia placeat officia! Corporis cum porro iure at praesentium quibusdam ea consectetur, unde vol");
            WriteLiteral(@"uptas deserunt.</span>
                </div>
                <div class=""list-item-time"">
                    <span>REQUESTED FOR 4:30 P.M. ON JUN 2021</span>
                </div>
            </li>
            <li class=""list-group-item"">
                <div class=""list-item-top"">
                    <div>
                        Gordon Freeman
                    </div>
                    <div class=""list-item-btn-con"">
                        <button class=""btn btn-danger"" data-bs-toggle=""modal"" data-bs-target=""#LeaveRequestModal"">Deny<i class=""fa-solid fa-hand""></i></button>
                        <button class=""btn btn-success"">Allow<i class=""fa-solid fa-thumbs-up""></i> </button>
                    </div>
                </div>
                <div class=""list-item-title"">
                    <span>Lorem ipsum dolor sit amet consectetur adipisicing elit. Quis dolorem, dolores inventore quidem quas ducimus mollitia placeat officia! Corporis cum porro iure at praesentium quibusdam ea consectetur, und");
            WriteLiteral(@"e voluptas deserunt.</span>
                </div>
                <div class=""list-item-time"">
                    <span>REQUESTED FOR 4:30 P.M. ON JUN 2021</span>
                </div>
            </li>
            <li class=""list-group-item"">
                <div class=""list-item-top"">
                    <div>
                        Gordon Freeman
                    </div>
                    <div class=""list-item-btn-con"">
                        <button class=""btn btn-danger"" data-bs-toggle=""modal"" data-bs-target=""#LeaveRequestModal"">Deny<i class=""fa-solid fa-hand""></i></button>
                        <button class=""btn btn-success"">Allow<i class=""fa-solid fa-thumbs-up""></i> </button>
                    </div>
                </div>
                <div class=""list-item-title"">
                    <span>Lorem ipsum dolor sit amet consectetur adipisicing elit. Quis dolorem, dolores inventore quidem quas ducimus mollitia placeat officia! Corporis cum porro iure at praesentium quibusdam ea consectetur");
            WriteLiteral(@", unde voluptas deserunt.</span>
                </div>
                <div class=""list-item-time"">
                    <span>REQUESTED FOR 4:30 P.M. ON JUN 2021</span>
                </div>
            </li>
            <li class=""list-group-item"">
                <div class=""list-item-top"">
                    <div>
                        Gordon Freeman
                    </div>
                    <div class=""list-item-btn-con"">
                        <button class=""btn btn-danger"" data-bs-toggle=""modal"" data-bs-target=""#LeaveRequestModal"">Deny<i class=""fa-solid fa-hand""></i></button>
                        <button class=""btn btn-success"">Allow<i class=""fa-solid fa-thumbs-up""></i> </button>
                    </div>
                </div>
                <div class=""list-item-title"">
                    <span>Lorem ipsum dolor sit amet consectetur adipisicing elit. Quis dolorem, dolores inventore quidem quas ducimus mollitia placeat officia! Corporis cum porro iure at praesentium quibusdam ea consec");
            WriteLiteral(@"tetur, unde voluptas deserunt.</span>
                </div>
                <div class=""list-item-time"">
                    <span>REQUESTED FOR 4:30 P.M. ON JUN 2021</span>
                </div>
            </li>
        </ul>
    </div>
</section>
<div class=""modal fade"" id=""LeaveRequestModal"" tabindex=""-1"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title leave-request-modal-title "" id=""exampleModalLabel"">Leave Request Denial</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <div class=""leave-request-modal-con"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96cbf43df87c749ba7e19a38e9824d91dbde6d4210143", async() => {
                WriteLiteral(@"
                        <span></span>
                        <div class=""input-group mb-3"">
                            <span class=""input-group-text"" id=""basic-addon1"">Denial Reason</span>
                            <textarea class=""form-control"" aria-label=""With textarea""></textarea>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn-cancel-modal"" data-bs-dismiss=""modal"">Cancel</button>
                <button type=""button"" id=""LeaveRequestAddBtn"" class=""btn-apply-modal"">Send and Apply</button>
            </div>
        </div>
    </div>
</div>

");
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
