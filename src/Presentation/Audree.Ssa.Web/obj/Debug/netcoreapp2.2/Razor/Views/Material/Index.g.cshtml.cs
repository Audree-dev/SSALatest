#pragma checksum "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Material\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe2c5ee0b19641d47e7df12969bfe05eb8645c2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Material_Index), @"mvc.1.0.view", @"/Views/Material/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Material/Index.cshtml", typeof(AspNetCore.Views_Material_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe2c5ee0b19641d47e7df12969bfe05eb8645c2e", @"/Views/Material/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c988de860ed95ce53f010ce16802aaa2d2abc829", @"/Views/_ViewImports.cshtml")]
    public class Views_Material_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Audree.Ssa.Core.ViewModel.MaterialViewmodel>>
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
            BeginContext(65, 11, true);
            WriteLiteral("\r\n<p>\r\n    ");
            EndContext();
            BeginContext(76, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe2c5ee0b19641d47e7df12969bfe05eb8645c2e3555", async() => {
                BeginContext(99, 10, true);
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
            BeginContext(113, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(206, 48, false);
#line 10 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Material\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Materialcode));

#line default
#line hidden
            EndContext();
            BeginContext(254, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(310, 55, false);
#line 13 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Material\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MaterialDescription));

#line default
#line hidden
            EndContext();
            BeginContext(365, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(421, 53, false);
#line 16 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Material\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MaterialGroupName));

#line default
#line hidden
            EndContext();
            BeginContext(474, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 22 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Material\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(592, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(641, 47, false);
#line 25 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Material\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Materialcode));

#line default
#line hidden
            EndContext();
            BeginContext(688, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(744, 54, false);
#line 28 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Material\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaterialDescription));

#line default
#line hidden
            EndContext();
            BeginContext(798, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(854, 52, false);
#line 31 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Material\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaterialGroupName));

#line default
#line hidden
            EndContext();
            BeginContext(906, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(962, 65, false);
#line 34 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Material\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1027, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1048, 71, false);
#line 35 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Material\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1119, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1140, 69, false);
#line 36 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Material\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1209, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 39 "D:\Projects\SSAAPI\src\Presentation\Audree.Ssa.Web\Views\Material\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1248, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Audree.Ssa.Core.ViewModel.MaterialViewmodel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
