#pragma checksum "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Roles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c1b86c79217f0044341fff877e2f74bc70ac016"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_Index), @"mvc.1.0.view", @"/Views/Roles/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Roles/Index.cshtml", typeof(AspNetCore.Views_Roles_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c1b86c79217f0044341fff877e2f74bc70ac016", @"/Views/Roles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f9c9151476449121b025acce2a418d33fc35c8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles_Index : DNTFrameworkCore.Web.Mvc.Views.WebViewPageBase<DNTFrameworkCore.ForexToolsWebApp.Models.Roles.RoleIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Roles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::DNTFrameworkCore.Web.Mvc.TagHelpers.Ajax.ModalLinkTagHelper __DNTFrameworkCore_Web_Mvc_TagHelpers_Ajax_ModalLinkTagHelper;
        private global::DNTFrameworkCore.Web.Mvc.TagHelpers.Authorization.AuthorizeTagHelper __DNTFrameworkCore_Web_Mvc_TagHelpers_Authorization_AuthorizeTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(73, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Roles\Index.cshtml"
  
    LocalizationResourceLocation = "DNTFrameworkCore.ForexToolsWebApp";
    ViewData["Title"] = L("Administration.Views.User.Index.Title");
    // ViewBag["ActiveMenu"] = AdministrationMenuNames.UserManagement;

#line default
#line hidden
            BeginContext(290, 70, true);
            WriteLiteral("\n<div class=\"row margin-bottom-5\">\n    <div class=\"col-md-2\">\n        ");
            EndContext();
            BeginContext(360, 202, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c1b86c79217f0044341fff877e2f74bc70ac0167423", async() => {
                BeginContext(489, 69, true);
                WriteLiteral("\n            <i class=\"fa fa-plus\"></i>\n            New Role\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __DNTFrameworkCore_Web_Mvc_TagHelpers_Ajax_ModalLinkTagHelper = CreateTagHelper<global::DNTFrameworkCore.Web.Mvc.TagHelpers.Ajax.ModalLinkTagHelper>();
            __tagHelperExecutionContext.Add(__DNTFrameworkCore_Web_Mvc_TagHelpers_Ajax_ModalLinkTagHelper);
            __DNTFrameworkCore_Web_Mvc_TagHelpers_Authorization_AuthorizeTagHelper = CreateTagHelper<global::DNTFrameworkCore.Web.Mvc.TagHelpers.Authorization.AuthorizeTagHelper>();
            __tagHelperExecutionContext.Add(__DNTFrameworkCore_Web_Mvc_TagHelpers_Authorization_AuthorizeTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("asp-modal-link", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
#line 11 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Roles\Index.cshtml"
                                                   WriteLiteral(PermissionNames.Roles_Create);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __DNTFrameworkCore_Web_Mvc_TagHelpers_Authorization_AuthorizeTagHelper.PermissionName = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-permission", __DNTFrameworkCore_Web_Mvc_TagHelpers_Authorization_AuthorizeTagHelper.PermissionName, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(562, 88, true);
            WriteLiteral("\n    </div>\n</div>\n\n<hr/>\n\n<div class=\"row\">\n    <div class=\"col-md-12\" id=\"RolesList\">\n");
            EndContext();
#line 22 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Roles\Index.cshtml"
         foreach (var item in Model.Items)
        {

#line default
#line hidden
            BeginContext(703, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(715, 258, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c1b86c79217f0044341fff877e2f74bc70ac01611192", async() => {
                BeginContext(884, 62, true);
                WriteLiteral("\n                <i class=\"fa fa-pencil\"></i>\n                ");
                EndContext();
                BeginContext(947, 9, false);
#line 27 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Roles\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(956, 13, true);
                WriteLiteral("\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __DNTFrameworkCore_Web_Mvc_TagHelpers_Ajax_ModalLinkTagHelper = CreateTagHelper<global::DNTFrameworkCore.Web.Mvc.TagHelpers.Ajax.ModalLinkTagHelper>();
            __tagHelperExecutionContext.Add(__DNTFrameworkCore_Web_Mvc_TagHelpers_Ajax_ModalLinkTagHelper);
            __DNTFrameworkCore_Web_Mvc_TagHelpers_Authorization_AuthorizeTagHelper = CreateTagHelper<global::DNTFrameworkCore.Web.Mvc.TagHelpers.Authorization.AuthorizeTagHelper>();
            __tagHelperExecutionContext.Add(__DNTFrameworkCore_Web_Mvc_TagHelpers_Authorization_AuthorizeTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("asp-modal-link", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 25 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Roles\Index.cshtml"
                                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 25 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Roles\Index.cshtml"
                                                                                    WriteLiteral(PermissionNames.Roles_Edit);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __DNTFrameworkCore_Web_Mvc_TagHelpers_Authorization_AuthorizeTagHelper.PermissionName = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-permission", __DNTFrameworkCore_Web_Mvc_TagHelpers_Authorization_AuthorizeTagHelper.PermissionName, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(973, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 29 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Roles\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(984, 19, true);
            WriteLiteral("    </div>\n</div>\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1020, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(1025, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5c1b86c79217f0044341fff877e2f74bc70ac01616399", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1067, 12, true);
                WriteLiteral("</partial>\n\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DNTFrameworkCore.ForexToolsWebApp.Models.Roles.RoleIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
