#pragma checksum "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33ffce381080b5047a67a8bce03902bbabfaae77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Convenor_Applicants), @"mvc.1.0.view", @"/Views/Convenor/Applicants.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Convenor/Applicants.cshtml", typeof(AspNetCore.Views_Convenor_Applicants))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33ffce381080b5047a67a8bce03902bbabfaae77", @"/Views/Convenor/Applicants.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6e7eae3f5dd2a636837a3e27401adaad074ec80", @"/Views/_ViewImports.cshtml")]
    public class Views_Convenor_Applicants : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SessionalAllocation.ViewModels.ApplicantsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "selectPref", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Convenor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateRating", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Nominate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: flex;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Classes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(71, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
  
    ViewData["Title"] = "Applicants";

#line default
#line hidden
            BeginContext(115, 102, true);
            WriteLiteral("\n<h1>Applicants</h1>\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(218, 67, false);
#line 13 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
           Write(Html.DisplayNameFor(model => model.Application.ApplicantNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(285, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(338, 70, false);
#line 16 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
           Write(Html.DisplayNameFor(model => model.Application.ProvisionallyAllocated));

#line default
#line hidden
            EndContext();
            BeginContext(408, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(461, 56, false);
#line 19 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
           Write(Html.DisplayNameFor(model => model.Application.Approved));

#line default
#line hidden
            EndContext();
            BeginContext(517, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(570, 70, false);
#line 22 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
           Write(Html.DisplayNameFor(model => model.Application.AppliedClassNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(640, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(693, 81, false);
#line 25 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
           Write(Html.DisplayNameFor(model => model.Application.ApplicantNavigation.Qualification));

#line default
#line hidden
            EndContext();
            BeginContext(774, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(827, 85, false);
#line 28 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
           Write(Html.DisplayNameFor(model => model.Application.ApplicantNavigation.QualificationName));

#line default
#line hidden
            EndContext();
            BeginContext(912, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(965, 58, false);
#line 31 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
           Write(Html.DisplayNameFor(model => model.Application.Preference));

#line default
#line hidden
            EndContext();
            BeginContext(1023, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1076, 18, false);
#line 34 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
           Write(Html.Raw("Rating"));

#line default
#line hidden
            EndContext();
            BeginContext(1094, 221, true);
            WriteLiteral("\n                <div class=\"help-tip\">\n                    <p>5 - Default <br /> >5 - Higher <br /> &lt5 - Lower </p>\n                </div>\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 43 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1362, 58, true);
            WriteLiteral("            <tr>\n                <td>\n                    ");
            EndContext();
            BeginContext(1420, 183, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33ffce381080b5047a67a8bce03902bbabfaae7710915", async() => {
                BeginContext(1524, 75, false);
#line 47 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
                                                                                                                      Write(Html.DisplayFor(modelItem => item.Application.ApplicantNavigation.FullName));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
                                                                     WriteLiteral(item.Application.ApplicantNavigation.Id);

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
            BeginContext(1603, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1668, 66, false);
#line 50 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
               Write(Html.Raw((item.Application.ProvisionallyAllocated) ? "Yes" : "No"));

#line default
#line hidden
            EndContext();
            BeginContext(1734, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1799, 52, false);
#line 53 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
               Write(Html.Raw((item.Application.Approved) ? "Yes" : "No"));

#line default
#line hidden
            EndContext();
            BeginContext(1851, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1916, 79, false);
#line 56 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
               Write(Html.DisplayFor(modelItem => item.Application.AppliedClassNavigation.ClassType));

#line default
#line hidden
            EndContext();
            BeginContext(1995, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(2060, 80, false);
#line 59 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
               Write(Html.DisplayFor(modelItem => item.Application.ApplicantNavigation.Qualification));

#line default
#line hidden
            EndContext();
            BeginContext(2140, 66, true);
            WriteLiteral("\n                </td>\n\n\n                <td>\n                    ");
            EndContext();
            BeginContext(2207, 84, false);
#line 64 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
               Write(Html.DisplayFor(modelItem => item.Application.ApplicantNavigation.QualificationName));

#line default
#line hidden
            EndContext();
            BeginContext(2291, 44, true);
            WriteLiteral("\n                </td>\n                <td>\n");
            EndContext();
#line 67 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
                     switch (item.Application.Preference)
                    {
                        case 1:
                            

#line default
#line hidden
            BeginContext(2476, 15, false);
#line 70 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
                       Write(Html.Raw("Low"));

#line default
#line hidden
            EndContext();
#line 70 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
                                            
                            break;
                        case 2:
                            

#line default
#line hidden
            BeginContext(2588, 18, false);
#line 73 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
                       Write(Html.Raw("Medium"));

#line default
#line hidden
            EndContext();
#line 73 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
                                               
                            break;
                        case 3:
                            

#line default
#line hidden
            BeginContext(2703, 16, false);
#line 76 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
                       Write(Html.Raw("High"));

#line default
#line hidden
            EndContext();
#line 76 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
                                             
                            break;
                        default:
                            

#line default
#line hidden
            BeginContext(2817, 24, false);
#line 79 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
                       Write(Html.Raw("Not selected"));

#line default
#line hidden
            EndContext();
#line 79 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
                                                     
                            break;
                    }

#line default
#line hidden
            BeginContext(2899, 43, true);
            WriteLiteral("                </td>\n                <td>\n");
            EndContext();
            BeginContext(3013, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(3033, 1073, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33ffce381080b5047a67a8bce03902bbabfaae7718628", async() => {
                BeginContext(3188, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 86 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
                          
                            // we need to reset the selected values to false or it may use the selected value for the previous application
                            for (int i = 0; i < ViewBag.LoadRatings.Count; i++)
                            {
                                ViewBag.LoadRatings[i].Selected = false;
                            }
                            // set selected value for current application

                            ViewBag.LoadRatings[item.rating].Selected = true;
                        

#line default
#line hidden
                BeginContext(3747, 59, true);
                WriteLiteral("                        <input type=\"hidden\" name=\"classId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3806, "\"", 3844, 1);
#line 96 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
WriteAttributeValue("", 3814, item.Application.AppliedClass, 3814, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3845, 28, true);
                WriteLiteral(" />\n                        ");
                EndContext();
                BeginContext(3873, 205, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33ffce381080b5047a67a8bce03902bbabfaae7720324", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 98 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.LoadRatings;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onchange", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4006, "AutoPostBack(", 4006, 13, true);
#line 99 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
AddHtmlAttributeValue("", 4019, "selectPref"+item.Application.ApplicationId, 4019, 46, false);

#line default
#line hidden
                AddHtmlAttributeValue("", 4065, ");", 4065, 2, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4078, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "name", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 85 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
AddHtmlAttributeValue("", 3045, "selectPref"+item.Application.ApplicationId, 3045, 46, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 85 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
                                                                                                                                      WriteLiteral(item.Application.Applicant);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4106, 23, true);
            WriteLiteral("\n                </td>\n");
            EndContext();
#line 102 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
                 if (!item.Application.ProvisionallyAllocated)
                {

#line default
#line hidden
            BeginContext(4210, 49, true);
            WriteLiteral("                    <td>\n                        ");
            EndContext();
            BeginContext(4259, 297, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33ffce381080b5047a67a8bce03902bbabfaae7726074", async() => {
                BeginContext(4383, 166, true);
                WriteLiteral("\n                            <input type=\"submit\" class=\"btn btn-primary\" value=\"Nominate\" onclick=\"return confirm(\'Applicant Nominated\')\" />\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 105 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
                                                                                WriteLiteral(item.Application.ApplicationId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4556, 27, true);
            WriteLiteral("\n                    </td>\n");
            EndContext();
#line 109 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
                }

#line default
#line hidden
            BeginContext(4601, 19, true);
            WriteLiteral("\n            </tr>\n");
            EndContext();
#line 112 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
        }

#line default
#line hidden
            BeginContext(4630, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
            EndContext();
#line 115 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(4672, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(4676, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33ffce381080b5047a67a8bce03902bbabfaae7729981", async() => {
                BeginContext(4781, 15, true);
                WriteLiteral("Back to Classes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 117 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
                              WriteLiteral(Model.FirstOrDefault().Application.AppliedClassNavigation.UnitId);

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
            BeginContext(4800, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 118 "D:\sessionalallocation\sessionalallocation\Views\Convenor\Applicants.cshtml"
}

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(4821, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(4826, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "33ffce381080b5047a67a8bce03902bbabfaae7732662", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4870, 112, true);
                WriteLiteral("\n\n    <script>\n        function AutoPostBack(formName) {\n            formName.submit();\n        }\n    </script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SessionalAllocation.ViewModels.ApplicantsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
