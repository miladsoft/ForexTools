#pragma checksum "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Shared\_DeleteConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1e7b4848c487f31dee21e61c7e4b1924b1be59c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DeleteConfirmation), @"mvc.1.0.view", @"/Views/Shared/_DeleteConfirmation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_DeleteConfirmation.cshtml", typeof(AspNetCore.Views_Shared__DeleteConfirmation))]
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
#line 1 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\_ViewImports.cshtml"
using DNTFrameworkCore.ForexToolsWebApp;

#line default
#line hidden
#line 2 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\_ViewImports.cshtml"
using DNTFrameworkCore.ForexToolsWebApp.Authorization;

#line default
#line hidden
#line 3 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\_ViewImports.cshtml"
using DNTFrameworkCore.ForexToolsWebApp.Models;

#line default
#line hidden
#line 4 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\_ViewImports.cshtml"
using DNTFrameworkCore.Web.Mvc;

#line default
#line hidden
#line 5 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\_ViewImports.cshtml"
using DNTFrameworkCore.Web.Mvc.HtmlHelpers;

#line default
#line hidden
#line 10 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\_ViewImports.cshtml"
using DNTFrameworkCore.Application.Models;

#line default
#line hidden
#line 11 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\_ViewImports.cshtml"
using DNTFrameworkCore.ForexToolsWebApp.Application.Blogging.Models;

#line default
#line hidden
#line 12 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\_ViewImports.cshtml"
using DNTFrameworkCore.ForexToolsWebApp.Application.Person.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1e7b4848c487f31dee21e61c7e4b1924b1be59c", @"/Views/Shared/_DeleteConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f9c9151476449121b025acce2a418d33fc35c8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__DeleteConfirmation : DNTFrameworkCore.Web.Mvc.Views.WebViewPageBase<DNTFrameworkCore.ForexToolsWebApp.Models.DeleteConfirmationModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-modal-form", "delete-confirmation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::DNTFrameworkCore.Web.Mvc.TagHelpers.Ajax.ModalFormTagHelper __DNTFrameworkCore_Web_Mvc_TagHelpers_Ajax_ModalFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(72, 130, true);
            WriteLiteral("\n<div class=\"modal-header\">\n    <h4 class=\"modal-title text-muted\">\n        <i class=\"fa fa-info-circle text-danger\"></i>\n        ");
            EndContext();
            BeginContext(203, 11, false);
#line 6 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Shared\_DeleteConfirmation.cshtml"
   Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(214, 91, true);
            WriteLiteral("</h4>\n    <button type=\"button\" class=\"close\" data-dismiss=\"modal\">&times;</button>\n</div>\n");
            EndContext();
            BeginContext(305, 533, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1e7b4848c487f31dee21e61c7e4b1924b1be59c5826", async() => {
                BeginContext(391, 55, true);
                WriteLiteral("\n\n    <div class=\"modal-body\">\n        <input name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 446, "\"", 468, 1);
#line 12 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Shared\_DeleteConfirmation.cshtml"
WriteAttributeValue("", 454, Model.ModelId, 454, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(469, 27, true);
                WriteLiteral(" type=\"hidden\"/>  \n        ");
                EndContext();
                BeginContext(497, 10, false);
#line 13 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Shared\_DeleteConfirmation.cshtml"
   Write(Model.Body);

#line default
#line hidden
                EndContext();
                BeginContext(507, 324, true);
                WriteLiteral(@"  
    </div>
    <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-light"" data-dismiss=""modal"">
            <i class=""fa fa-ban""></i>&nbsp; Cancel
        </button>
        <button type=""submit"" class=""btn btn-danger"">
            <i class=""fa fa-trash""></i>&nbsp; Delete
        </button>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __DNTFrameworkCore_Web_Mvc_TagHelpers_Ajax_ModalFormTagHelper = CreateTagHelper<global::DNTFrameworkCore.Web.Mvc.TagHelpers.Ajax.ModalFormTagHelper>();
            __tagHelperExecutionContext.Add(__DNTFrameworkCore_Web_Mvc_TagHelpers_Ajax_ModalFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 9 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Shared\_DeleteConfirmation.cshtml"
AddHtmlAttributeValue("", 319, Model.Url, 319, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
#line 9 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Shared\_DeleteConfirmation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-antiforgery", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __DNTFrameworkCore_Web_Mvc_TagHelpers_Ajax_ModalFormTagHelper.FormId = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(838, 11, true);
            WriteLiteral("\n\n    \n    ");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DNTFrameworkCore.ForexToolsWebApp.Models.DeleteConfirmationModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
