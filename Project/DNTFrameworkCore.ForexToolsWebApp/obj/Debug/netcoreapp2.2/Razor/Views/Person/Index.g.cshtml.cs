#pragma checksum "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Person\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0ca2a22f081fc97cecd155e04a07d26bfcef8e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Index), @"mvc.1.0.view", @"/Views/Person/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Person/Index.cshtml", typeof(AspNetCore.Views_Person_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0ca2a22f081fc97cecd155e04a07d26bfcef8e9", @"/Views/Person/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f9c9151476449121b025acce2a418d33fc35c8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Index : DNTFrameworkCore.Web.Mvc.Views.WebViewPageBase<IPagedQueryResult<PersonModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Person", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Delete Blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::DNTFrameworkCore.ForexToolsWebApp.Helpers.ModalDeleteLinkTagHelper __DNTFrameworkCore_ForexToolsWebApp_Helpers_ModalDeleteLinkTagHelper;
        private global::DNTFrameworkCore.Web.Mvc.TagHelpers.IfAttributeTagHelper __DNTFrameworkCore_Web_Mvc_TagHelpers_IfAttributeTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Person\Index.cshtml"
  
    LocalizationResourceLocation = "DNTFrameworkCore.ForexToolsWebApp";
    ViewData["Title"] = L("Administration.Views.Person.Index.Title");
  //  ViewBag["ActiveMenu"] = AdministrationMenuNames.UserManagement;

#line default
#line hidden
            BeginContext(263, 73, true);
            WriteLiteral("\r\n<div class=\"row margin-bottom-5\">\r\n    <div class=\"col-md-2\">\r\n        ");
            EndContext();
            BeginContext(336, 209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0ca2a22f081fc97cecd155e04a07d26bfcef8e98362", async() => {
                BeginContext(467, 74, true);
                WriteLiteral("\r\n            <i class=\"fa fa-plus\"></i>\r\n            New Person\r\n        ");
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
#line 11 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Person\Index.cshtml"
                                                   WriteLiteral(PermissionNames.Person_Create);

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
            BeginContext(545, 71, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<hr />\r\n\r\n<div class=\"row\" id=\"PersonList\">\r\n\r\n");
            EndContext();
#line 22 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Person\Index.cshtml"
     foreach (var item in Model.Items)
    {

#line default
#line hidden
            BeginContext(663, 135, true);
            WriteLiteral("        <div class=\"col-md-6\">\r\n            <div class=\"card mb-lg-4\">\r\n                <div class=\"card-header\">\r\n                    ");
            EndContext();
            BeginContext(799, 9, false);
#line 27 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Person\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(808, 125, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <input type=\"text\" readonly=\"readonly\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 933, "\"", 953, 1);
#line 30 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Person\Index.cshtml"
WriteAttributeValue("", 941, item.Family, 941, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(954, 113, true);
            WriteLiteral(" class=\"form-control\" />\r\n                </div>\r\n                <div class=\"card-footer\">\r\n                    ");
            EndContext();
            BeginContext(1067, 286, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0ca2a22f081fc97cecd155e04a07d26bfcef8e913284", async() => {
                BeginContext(1243, 106, true);
                WriteLiteral("\r\n                        <i class=\"fa fa-pencil\"></i>\r\n                        Edit\r\n                    ");
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
#line 34 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Person\Index.cshtml"
                                                                   WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 34 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Person\Index.cshtml"
                                                                                             WriteLiteral(PermissionNames.Person_Edit);

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
            BeginContext(1353, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1375, 378, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0ca2a22f081fc97cecd155e04a07d26bfcef8e917759", async() => {
                BeginContext(1630, 119, true);
                WriteLiteral("\r\n                        <i class=\"fa fa-trash text-danger\"></i>\r\n                        Delete\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __DNTFrameworkCore_ForexToolsWebApp_Helpers_ModalDeleteLinkTagHelper = CreateTagHelper<global::DNTFrameworkCore.ForexToolsWebApp.Helpers.ModalDeleteLinkTagHelper>();
            __tagHelperExecutionContext.Add(__DNTFrameworkCore_ForexToolsWebApp_Helpers_ModalDeleteLinkTagHelper);
            __DNTFrameworkCore_Web_Mvc_TagHelpers_IfAttributeTagHelper = CreateTagHelper<global::DNTFrameworkCore.Web.Mvc.TagHelpers.IfAttributeTagHelper>();
            __tagHelperExecutionContext.Add(__DNTFrameworkCore_Web_Mvc_TagHelpers_IfAttributeTagHelper);
            __DNTFrameworkCore_Web_Mvc_TagHelpers_Authorization_AuthorizeTagHelper = CreateTagHelper<global::DNTFrameworkCore.Web.Mvc.TagHelpers.Authorization.AuthorizeTagHelper>();
            __tagHelperExecutionContext.Add(__DNTFrameworkCore_Web_Mvc_TagHelpers_Authorization_AuthorizeTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("asp-modal-delete-link", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
#line 38 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Person\Index.cshtml"
                                                                     WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __DNTFrameworkCore_ForexToolsWebApp_Helpers_ModalDeleteLinkTagHelper.ModelId = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-model-id", __DNTFrameworkCore_ForexToolsWebApp_Helpers_ModalDeleteLinkTagHelper.ModelId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 39 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Person\Index.cshtml"
__DNTFrameworkCore_Web_Mvc_TagHelpers_IfAttributeTagHelper.Include = !@item.IsNew();

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-if", __DNTFrameworkCore_Web_Mvc_TagHelpers_IfAttributeTagHelper.Include, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 39 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Person\Index.cshtml"
                                                                                               WriteLiteral(PermissionNames.Person_Delete);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __DNTFrameworkCore_Web_Mvc_TagHelpers_Authorization_AuthorizeTagHelper.PermissionName = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-permission", __DNTFrameworkCore_Web_Mvc_TagHelpers_Authorization_AuthorizeTagHelper.PermissionName, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1753, 62, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 47 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Person\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1822, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1849, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1855, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e0ca2a22f081fc97cecd155e04a07d26bfcef8e923288", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1897, 14, true);
                WriteLiteral("</partial>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedQueryResult<PersonModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591