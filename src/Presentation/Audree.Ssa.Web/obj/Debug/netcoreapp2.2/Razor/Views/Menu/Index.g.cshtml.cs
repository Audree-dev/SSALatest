#pragma checksum "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Menu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bad3fc17538c4311e79884aff0d39dbb1c64cf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_Index), @"mvc.1.0.view", @"/Views/Menu/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Menu/Index.cshtml", typeof(AspNetCore.Views_Menu_Index))]
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
#line 1 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\_ViewImports.cshtml"
using Audree.Ssa.Web;

#line default
#line hidden
#line 2 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\_ViewImports.cshtml"
using Audree.Ssa.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bad3fc17538c4311e79884aff0d39dbb1c64cf8", @"/Views/Menu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c988de860ed95ce53f010ce16802aaa2d2abc829", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Audree.Ssa.Core.ViewModel.MenuViewmodel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 11, true);
            WriteLiteral("\r\n<p>\r\n    ");
            EndContext();
            BeginContext(72, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bad3fc17538c4311e79884aff0d39dbb1c64cf83523", async() => {
                BeginContext(95, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(109, 170, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                model => model.LinkText\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(280, 42, false);
#line 13 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Menu\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Action));

#line default
#line hidden
            EndContext();
            BeginContext(322, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(378, 46, false);
#line 16 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Menu\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Controller));

#line default
#line hidden
            EndContext();
            BeginContext(424, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(480, 45, false);
#line 19 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Menu\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProfileId));

#line default
#line hidden
            EndContext();
            BeginContext(525, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(581, 45, false);
#line 22 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Menu\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MenuOrder));

#line default
#line hidden
            EndContext();
            BeginContext(626, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(682, 47, false);
#line 25 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Menu\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DefaultMenu));

#line default
#line hidden
            EndContext();
            BeginContext(729, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(785, 42, false);
#line 28 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Menu\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Active));

#line default
#line hidden
            EndContext();
            BeginContext(827, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(883, 40, false);
#line 31 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Menu\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Icon));

#line default
#line hidden
            EndContext();
            BeginContext(923, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(979, 42, false);
#line 34 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Menu\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MenuId));

#line default
#line hidden
            EndContext();
            BeginContext(1021, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1077, 42, false);
#line 37 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Menu\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RoleId));

#line default
#line hidden
            EndContext();
            BeginContext(1119, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1175, 42, false);
#line 40 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Menu\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TempId));

#line default
#line hidden
            EndContext();
            BeginContext(1217, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 46 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Menu\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1335, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1384, 43, false);
#line 49 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Menu\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LinkText));

#line default
#line hidden
            EndContext();
            BeginContext(1427, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1483, 41, false);
#line 52 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Menu\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Action));

#line default
#line hidden
            EndContext();
            BeginContext(1524, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1580, 45, false);
#line 55 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Menu\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Controller));

#line default
#line hidden
            EndContext();
            BeginContext(1625, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1681, 44, false);
#line 58 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Menu\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProfileId));

#line default
#line hidden
            EndContext();
            BeginContext(1725, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1781, 44, false);
#line 61 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Menu\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MenuOrder));

#line default
#line hidden
            EndContext();
            BeginContext(1825, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1881, 46, false);
#line 64 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Menu\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DefaultMenu));

#line default
#line hidden
            EndContext();
            BeginContext(1927, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1983, 41, false);
#line 67 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Menu\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Active));

#line default
#line hidden
            EndContext();
            BeginContext(2024, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2080, 39, false);
#line 70 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Menu\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Icon));

#line default
#line hidden
            EndContext();
            BeginContext(2119, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2175, 41, false);
#line 73 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Menu\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MenuId));

#line default
#line hidden
            EndContext();
            BeginContext(2216, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2272, 41, false);
#line 76 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Menu\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RoleId));

#line default
#line hidden
            EndContext();
            BeginContext(2313, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2369, 41, false);
#line 79 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Menu\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TempId));

#line default
#line hidden
            EndContext();
            BeginContext(2410, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2466, 65, false);
#line 82 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Menu\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2531, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2552, 71, false);
#line 83 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Menu\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2623, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2644, 69, false);
#line 84 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Menu\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2713, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 87 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Menu\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2752, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Audree.Ssa.Core.ViewModel.MenuViewmodel>> Html { get; private set; }
    }
}
#pragma warning restore 1591