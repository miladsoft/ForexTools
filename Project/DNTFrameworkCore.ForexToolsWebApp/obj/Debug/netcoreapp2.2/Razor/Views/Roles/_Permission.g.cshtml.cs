#pragma checksum "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Roles\_Permission.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8722311007437367e769436b9f976c9050b1918c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles__Permission), @"mvc.1.0.view", @"/Views/Roles/_Permission.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Roles/_Permission.cshtml", typeof(AspNetCore.Views_Roles__Permission))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8722311007437367e769436b9f976c9050b1918c", @"/Views/Roles/_Permission.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f9c9151476449121b025acce2a418d33fc35c8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles__Permission : DNTFrameworkCore.Web.Mvc.Views.WebViewPageBase<DNTFrameworkCore.ForexToolsWebApp.Application.Identity.Models.PermissionModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Roles\_Permission.cshtml"
 using (Html.BeginCollectionItem("Permissions"))
{
    

#line default
#line hidden
            BeginContext(144, 25, false);
#line 4 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Roles\_Permission.cshtml"
Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
            EndContext();
            BeginContext(176, 36, false);
#line 5 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Roles\_Permission.cshtml"
Write(Html.HiddenFor(m => m.TrackingState));

#line default
#line hidden
            EndContext();
#line 5 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Roles\_Permission.cshtml"
                                         
    //todo: using checkboxes


#line default
#line hidden
            BeginContext(246, 52, true);
            WriteLiteral("    <input type=\"checkbox\" name=\"name\" value=\"\" />\r\n");
            EndContext();
#line 9 "E:\Programming\GitHub\ForexTools\Project\DNTFrameworkCore.ForexToolsWebApp\Views\Roles\_Permission.cshtml"
}

#line default
#line hidden
            BeginContext(301, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DNTFrameworkCore.ForexToolsWebApp.Application.Identity.Models.PermissionModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
