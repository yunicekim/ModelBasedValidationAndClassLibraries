#pragma checksum "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKPatientTreatment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba77c4e5e58428190be66d0dec89fc2ac5866aba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_YKPatientTreatment_Index), @"mvc.1.0.view", @"/Views/YKPatientTreatment/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/YKPatientTreatment/Index.cshtml", typeof(AspNetCore.Views_YKPatientTreatment_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba77c4e5e58428190be66d0dec89fc2ac5866aba", @"/Views/YKPatientTreatment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0e95ca58ad92ae83cbe7fa6e3f0386e4c90d27d", @"/Views/_ViewImports.cshtml")]
    public class Views_YKPatientTreatment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<YKPatients.Models.PatientTreatment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKPatientTreatment\Index.cshtml"
  
    ViewData["Title"] = $"Treatment for {ViewData["diagnosisName"]}, Patient: {ViewData["lastName"]}, {ViewData["firstName"]}";

#line default
#line hidden
            BeginContext(194, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(201, 17, false);
#line 7 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKPatientTreatment\Index.cshtml"
Write(ViewData["title"]);

#line default
#line hidden
            EndContext();
            BeginContext(218, 18, true);
            WriteLiteral("</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(236, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba77c4e5e58428190be66d0dec89fc2ac5866aba5603", async() => {
                BeginContext(259, 20, true);
                WriteLiteral("Add a Treatment for ");
                EndContext();
                BeginContext(280, 25, false);
#line 10 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKPatientTreatment\Index.cshtml"
                                          Write(ViewData["diagnosisName"]);

#line default
#line hidden
                EndContext();
                BeginContext(305, 11, true);
                WriteLiteral(", Patient: ");
                EndContext();
                BeginContext(317, 20, false);
#line 10 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKPatientTreatment\Index.cshtml"
                                                                               Write(ViewData["lastName"]);

#line default
#line hidden
                EndContext();
                BeginContext(337, 2, true);
                WriteLiteral(", ");
                EndContext();
                BeginContext(340, 21, false);
#line 10 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKPatientTreatment\Index.cshtml"
                                                                                                      Write(ViewData["firstName"]);

#line default
#line hidden
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
            BeginContext(365, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(458, 50, false);
#line 16 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKPatientTreatment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DatePrescribed));

#line default
#line hidden
            EndContext();
            BeginContext(508, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(564, 44, false);
#line 19 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKPatientTreatment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Comments));

#line default
#line hidden
            EndContext();
            BeginContext(608, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(664, 52, false);
#line 22 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKPatientTreatment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PatientDiagnosis));

#line default
#line hidden
            EndContext();
            BeginContext(716, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(772, 45, false);
#line 25 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKPatientTreatment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Treatment));

#line default
#line hidden
            EndContext();
            BeginContext(817, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKPatientTreatment\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(935, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(984, 49, false);
#line 34 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKPatientTreatment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DatePrescribed));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1089, 43, false);
#line 37 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKPatientTreatment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Comments));

#line default
#line hidden
            EndContext();
            BeginContext(1132, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1188, 70, false);
#line 40 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKPatientTreatment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PatientDiagnosis.PatientDiagnosisId));

#line default
#line hidden
            EndContext();
            BeginContext(1258, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1314, 49, false);
#line 43 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKPatientTreatment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Treatment.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1363, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1418, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba77c4e5e58428190be66d0dec89fc2ac5866aba13022", async() => {
                BeginContext(1479, 4, true);
                WriteLiteral("Edit");
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
#line 46 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKPatientTreatment\Index.cshtml"
                                       WriteLiteral(item.PatientTreatmentId);

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
            BeginContext(1487, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1507, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba77c4e5e58428190be66d0dec89fc2ac5866aba15469", async() => {
                BeginContext(1571, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKPatientTreatment\Index.cshtml"
                                          WriteLiteral(item.PatientTreatmentId);

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
            BeginContext(1582, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1602, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba77c4e5e58428190be66d0dec89fc2ac5866aba17922", async() => {
                BeginContext(1665, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKPatientTreatment\Index.cshtml"
                                         WriteLiteral(item.PatientTreatmentId);

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
            BeginContext(1675, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 51 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKPatientTreatment\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1714, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<YKPatients.Models.PatientTreatment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
