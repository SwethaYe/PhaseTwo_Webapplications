#pragma checksum "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day3_CoreMVCConcepts\Views\Employee\GetEmployees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e99429602b6681e393130259feef8994e877f276"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_GetEmployees), @"mvc.1.0.view", @"/Views/Employee/GetEmployees.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day3_CoreMVCConcepts\Views\_ViewImports.cshtml"
using Day3_CoreMVCConcepts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day3_CoreMVCConcepts\Views\_ViewImports.cshtml"
using Day3_CoreMVCConcepts.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e99429602b6681e393130259feef8994e877f276", @"/Views/Employee/GetEmployees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fac6e75c41161876804ab9f21bda2772242baafe", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_GetEmployees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Day3_CoreMVCConcepts.Models.Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day3_CoreMVCConcepts\Views\Employee\GetEmployees.cshtml"
  
    ViewData["Title"] = "GetEmployees";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>GetEmployees</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e99429602b6681e393130259feef8994e877f2764024", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 16 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day3_CoreMVCConcepts\Views\Employee\GetEmployees.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 19 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day3_CoreMVCConcepts\Views\Employee\GetEmployees.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 22 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day3_CoreMVCConcepts\Views\Employee\GetEmployees.cshtml"
           Write(Html.DisplayNameFor(model => model.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 25 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day3_CoreMVCConcepts\Views\Employee\GetEmployees.cshtml"
           Write(Html.DisplayNameFor(model => model.Designation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 31 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day3_CoreMVCConcepts\Views\Employee\GetEmployees.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 34 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day3_CoreMVCConcepts\Views\Employee\GetEmployees.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 37 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day3_CoreMVCConcepts\Views\Employee\GetEmployees.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 40 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day3_CoreMVCConcepts\Views\Employee\GetEmployees.cshtml"
           Write(Html.DisplayFor(modelItem => item.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 43 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day3_CoreMVCConcepts\Views\Employee\GetEmployees.cshtml"
           Write(Html.DisplayFor(modelItem => item.Designation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 46 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day3_CoreMVCConcepts\Views\Employee\GetEmployees.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                ");
#nullable restore
#line 47 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day3_CoreMVCConcepts\Views\Employee\GetEmployees.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                ");
#nullable restore
#line 48 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day3_CoreMVCConcepts\Views\Employee\GetEmployees.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 51 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day3_CoreMVCConcepts\Views\Employee\GetEmployees.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Day3_CoreMVCConcepts.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591