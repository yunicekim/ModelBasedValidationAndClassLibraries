#pragma checksum "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7b5d4f3bd779556fed0ee1e42603bea854e3cb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_YKMedications_Delete), @"mvc.1.0.view", @"/Views/YKMedications/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/YKMedications/Delete.cshtml", typeof(AspNetCore.Views_YKMedications_Delete))]
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
#line 1 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\_ViewImports.cshtml"
using YKPatients;

#line default
#line hidden
#line 2 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\_ViewImports.cshtml"
using YKPatients.Models;

#line default
#line hidden
#line 2 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Delete.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7b5d4f3bd779556fed0ee1e42603bea854e3cb8", @"/Views/YKMedications/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0e95ca58ad92ae83cbe7fa6e3f0386e4c90d27d", @"/Views/_ViewImports.cshtml")]
    public class Views_YKMedications_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<YKPatients.Models.Medication>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Delete.cshtml"
  
    ViewData["Title"] = "Delete Medication for '" + Context.Session.GetString("medicationTypeName")+"'";

#line default
#line hidden
            BeginContext(186, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(193, 17, false);
#line 8 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Delete.cshtml"
Write(ViewData["title"]);

#line default
#line hidden
            EndContext();
            BeginContext(210, 84, true);
            WriteLiteral("</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Medication \'");
            EndContext();
            BeginContext(295, 36, false);
#line 12 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(331, 85, true);
            WriteLiteral("\'</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-4\">\r\n            ");
            EndContext();
            BeginContext(417, 39, false);
#line 16 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Din));

#line default
#line hidden
            EndContext();
            BeginContext(456, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
            EndContext();
            BeginContext(517, 35, false);
#line 19 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Din));

#line default
#line hidden
            EndContext();
            BeginContext(552, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
            EndContext();
            BeginContext(613, 40, false);
#line 22 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(653, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
            EndContext();
            BeginContext(714, 36, false);
#line 25 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(750, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
            EndContext();
            BeginContext(811, 41, false);
#line 28 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(852, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
            EndContext();
            BeginContext(913, 37, false);
#line 31 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(950, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
            EndContext();
            BeginContext(1011, 49, false);
#line 34 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Concentration));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
            EndContext();
            BeginContext(1121, 45, false);
#line 37 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Concentration));

#line default
#line hidden
            EndContext();
            BeginContext(1166, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
            EndContext();
            BeginContext(1227, 63, false);
#line 40 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ConcentrationCodeNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1290, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
            EndContext();
            BeginContext(1351, 77, false);
#line 43 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ConcentrationCodeNavigation.ConcentrationCode));

#line default
#line hidden
            EndContext();
            BeginContext(1428, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
            EndContext();
            BeginContext(1489, 60, false);
#line 46 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DispensingCodeNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1549, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
            EndContext();
            BeginContext(1610, 71, false);
#line 49 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DispensingCodeNavigation.DispensingCode));

#line default
#line hidden
            EndContext();
            BeginContext(1681, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
            EndContext();
            BeginContext(1742, 50, false);
#line 52 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MedicationType));

#line default
#line hidden
            EndContext();
            BeginContext(1792, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
            EndContext();
            BeginContext(1853, 51, false);
#line 55 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MedicationType.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1904, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1942, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7b5d4f3bd779556fed0ee1e42603bea854e3cb813584", async() => {
                BeginContext(1968, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1978, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f7b5d4f3bd779556fed0ee1e42603bea854e3cb813977", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 60 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Din);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2015, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2098, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7b5d4f3bd779556fed0ee1e42603bea854e3cb815965", async() => {
                    BeginContext(2120, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2136, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2149, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<YKPatients.Models.Medication> Html { get; private set; }
    }
}
#pragma warning restore 1591
