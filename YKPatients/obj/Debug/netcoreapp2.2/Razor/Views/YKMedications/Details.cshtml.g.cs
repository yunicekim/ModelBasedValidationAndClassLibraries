#pragma checksum "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41e97d45bbfda6c5d61f7e73bf61ba01363459ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_YKMedications_Details), @"mvc.1.0.view", @"/Views/YKMedications/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/YKMedications/Details.cshtml", typeof(AspNetCore.Views_YKMedications_Details))]
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
#line 2 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Details.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41e97d45bbfda6c5d61f7e73bf61ba01363459ed", @"/Views/YKMedications/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0e95ca58ad92ae83cbe7fa6e3f0386e4c90d27d", @"/Views/_ViewImports.cshtml")]
    public class Views_YKMedications_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<YKPatients.Models.Medication>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Details.cshtml"
  
    ViewData["Title"] = "Details for Medication for '" + Context.Session.GetString("medicationTypeName")+"'";

#line default
#line hidden
            BeginContext(191, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(198, 17, false);
#line 8 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Details.cshtml"
Write(ViewData["title"]);

#line default
#line hidden
            EndContext();
            BeginContext(215, 36, true);
            WriteLiteral("</h1>\r\n\r\n<div>\r\n    <h4>Medication \'");
            EndContext();
            BeginContext(252, 36, false);
#line 11 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Details.cshtml"
               Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(288, 85, true);
            WriteLiteral("\'</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-4\">\r\n            ");
            EndContext();
            BeginContext(374, 39, false);
#line 15 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Din));

#line default
#line hidden
            EndContext();
            BeginContext(413, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
            EndContext();
            BeginContext(474, 35, false);
#line 18 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Details.cshtml"
       Write(Html.DisplayFor(model => model.Din));

#line default
#line hidden
            EndContext();
            BeginContext(509, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
            EndContext();
            BeginContext(570, 40, false);
#line 21 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(610, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
            EndContext();
            BeginContext(671, 36, false);
#line 24 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(707, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
            EndContext();
            BeginContext(768, 41, false);
#line 27 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(809, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
            EndContext();
            BeginContext(870, 37, false);
#line 30 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Details.cshtml"
       Write(Html.DisplayFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(907, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
            EndContext();
            BeginContext(968, 49, false);
#line 33 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Concentration));

#line default
#line hidden
            EndContext();
            BeginContext(1017, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
            EndContext();
            BeginContext(1078, 45, false);
#line 36 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Details.cshtml"
       Write(Html.DisplayFor(model => model.Concentration));

#line default
#line hidden
            EndContext();
            BeginContext(1123, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
            EndContext();
            BeginContext(1184, 63, false);
#line 39 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ConcentrationCodeNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1247, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
            EndContext();
            BeginContext(1308, 77, false);
#line 42 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Details.cshtml"
       Write(Html.DisplayFor(model => model.ConcentrationCodeNavigation.ConcentrationCode));

#line default
#line hidden
            EndContext();
            BeginContext(1385, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
            EndContext();
            BeginContext(1446, 60, false);
#line 45 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DispensingCodeNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1506, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
            EndContext();
            BeginContext(1567, 71, false);
#line 48 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Details.cshtml"
       Write(Html.DisplayFor(model => model.DispensingCodeNavigation.DispensingCode));

#line default
#line hidden
            EndContext();
            BeginContext(1638, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
            EndContext();
            BeginContext(1699, 50, false);
#line 51 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MedicationType));

#line default
#line hidden
            EndContext();
            BeginContext(1749, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
            EndContext();
            BeginContext(1810, 51, false);
#line 54 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Details.cshtml"
       Write(Html.DisplayFor(model => model.MedicationType.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1861, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1908, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41e97d45bbfda6c5d61f7e73bf61ba01363459ed12864", async() => {
                BeginContext(1955, 4, true);
                WriteLiteral("Edit");
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
#line 59 "C:\Users\yunic\OneDrive\Documents\Study\School\Level 3\PROG2230-5 Programming-MS Web Tech\Assign\Assign4\YKPatients\YKPatients\Views\YKMedications\Details.cshtml"
                           WriteLiteral(Model.Din);

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
            BeginContext(1963, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1971, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41e97d45bbfda6c5d61f7e73bf61ba01363459ed15269", async() => {
                BeginContext(1993, 12, true);
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
            BeginContext(2009, 10, true);
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
