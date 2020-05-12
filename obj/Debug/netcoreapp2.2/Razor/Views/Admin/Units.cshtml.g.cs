#pragma checksum "D:\sessionalallocation\sessionalallocation\Views\Admin\Units.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ff2b7403b309dcec4cd51987902422b9f5648ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Units), @"mvc.1.0.view", @"/Views/Admin/Units.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Units.cshtml", typeof(AspNetCore.Views_Admin_Units))]
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
#line 1 "D:\sessionalallocation\sessionalallocation\Views\_ViewImports.cshtml"
using SessionalAllocation;

#line default
#line hidden
#line 2 "D:\sessionalallocation\sessionalallocation\Views\_ViewImports.cshtml"
using SessionalAllocation.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ff2b7403b309dcec4cd51987902422b9f5648ac", @"/Views/Admin/Units.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6e7eae3f5dd2a636837a3e27401adaad074ec80", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Units : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SessionalAllocation.Models.Unit>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditUnit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailsUnit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllDepartments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(52, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "D:\sessionalallocation\sessionalallocation\Views\Admin\Units.cshtml"
  
    ViewData["Title"] = "All Units";
    // This page is an admin page used to view ALL units of a department, able to edit the unit details and set an owner

#line default
#line hidden
            BeginContext(216, 108, true);
            WriteLiteral("\n<h1>Units</h1>\n\n<table class=\"table\" id=\"Units\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(325, 44, false);
#line 14 "D:\sessionalallocation\sessionalallocation\Views\Admin\Units.cshtml"
           Write(Html.DisplayNameFor(model => model.UnitCode));

#line default
#line hidden
            EndContext();
            BeginContext(369, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(422, 44, false);
#line 17 "D:\sessionalallocation\sessionalallocation\Views\Admin\Units.cshtml"
           Write(Html.DisplayNameFor(model => model.UnitName));

#line default
#line hidden
            EndContext();
            BeginContext(466, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(519, 56, false);
#line 20 "D:\sessionalallocation\sessionalallocation\Views\Admin\Units.cshtml"
           Write(Html.DisplayNameFor(model => model.DepartmentNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(575, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(628, 55, false);
#line 23 "D:\sessionalallocation\sessionalallocation\Views\Admin\Units.cshtml"
           Write(Html.DisplayNameFor(model => model.UnitOwnerNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(683, 80, true);
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 29 "D:\sessionalallocation\sessionalallocation\Views\Admin\Units.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(810, 58, true);
            WriteLiteral("            <tr>\n                <td>\n                    ");
            EndContext();
            BeginContext(869, 43, false);
#line 33 "D:\sessionalallocation\sessionalallocation\Views\Admin\Units.cshtml"
               Write(Html.DisplayFor(modelItem => item.UnitCode));

#line default
#line hidden
            EndContext();
            BeginContext(912, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(977, 43, false);
#line 36 "D:\sessionalallocation\sessionalallocation\Views\Admin\Units.cshtml"
               Write(Html.DisplayFor(modelItem => item.UnitName));

#line default
#line hidden
            EndContext();
            BeginContext(1020, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1085, 60, false);
#line 39 "D:\sessionalallocation\sessionalallocation\Views\Admin\Units.cshtml"
               Write(Html.DisplayFor(modelItem => item.DepartmentNavigation.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1145, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1210, 63, false);
#line 42 "D:\sessionalallocation\sessionalallocation\Views\Admin\Units.cshtml"
               Write(Html.DisplayFor(modelItem => item.UnitOwnerNavigation.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(1273, 107, true);
            WriteLiteral("\n                </td>\n                <td>\n                    <!-- <a asp-action=\"Classes\" asp-route-id=\"");
            EndContext();
            BeginContext(1381, 7, false);
#line 45 "D:\sessionalallocation\sessionalallocation\Views\Admin\Units.cshtml"
                                                          Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1388, 39, true);
            WriteLiteral("\">Classes</a> |-->\n                    ");
            EndContext();
            BeginContext(1427, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ff2b7403b309dcec4cd51987902422b9f5648ac8731", async() => {
                BeginContext(1476, 9, true);
                WriteLiteral("Edit Unit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "D:\sessionalallocation\sessionalallocation\Views\Admin\Units.cshtml"
                                               WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1489, 23, true);
            WriteLiteral(" |\n                    ");
            EndContext();
            BeginContext(1512, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ff2b7403b309dcec4cd51987902422b9f5648ac11079", async() => {
                BeginContext(1564, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "D:\sessionalallocation\sessionalallocation\Views\Admin\Units.cshtml"
                                                  WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1575, 41, true);
            WriteLiteral("\n                </td>\n            </tr>\n");
            EndContext();
#line 50 "D:\sessionalallocation\sessionalallocation\Views\Admin\Units.cshtml"
        }

#line default
#line hidden
            BeginContext(1626, 32, true);
            WriteLiteral("    </tbody>\n</table>\n<div>\n    ");
            EndContext();
            BeginContext(1658, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ff2b7403b309dcec4cd51987902422b9f5648ac13706", async() => {
                BeginContext(1689, 19, true);
                WriteLiteral("Back to Departments");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            BeginContext(1712, 10, true);
            WriteLiteral("\n</div>\n\n\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1740, 182, true);
                WriteLiteral("\n\n    \n    <script type=\"text/javascript\">\n        $(document).ready(function () {\n            $(\'#Units\').filterTable({ minRows: 0, ignoreColumns: [4] });\n        });\n    </script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SessionalAllocation.Models.Unit>> Html { get; private set; }
    }
}
#pragma warning restore 1591
