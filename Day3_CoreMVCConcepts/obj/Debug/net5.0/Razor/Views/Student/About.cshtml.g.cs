#pragma checksum "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day3_CoreMVCConcepts\Views\Student\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26e2d12ad2eb64080852abb7f690afe9655f3fd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_About), @"mvc.1.0.view", @"/Views/Student/About.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26e2d12ad2eb64080852abb7f690afe9655f3fd9", @"/Views/Student/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fac6e75c41161876804ab9f21bda2772242baafe", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day3_CoreMVCConcepts\Views\Student\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 8 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day3_CoreMVCConcepts\Views\Student\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n<div class=\"badge-success\">\n    There are ");
#nullable restore
#line 10 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day3_CoreMVCConcepts\Views\Student\About.cshtml"
         Write(ViewData["StudentCount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" participants have joined.\n</div>\n<table class=\"table\">\n    <thead>\n        <th>Student Id</th>\n        <th>Name</th>\n        <th>City</th>\n        <th>\n            Gender\n        </th>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 22 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day3_CoreMVCConcepts\Views\Student\About.cshtml"
         foreach(var item in @ViewData["StudentList"] as IList<Student>)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 25 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day3_CoreMVCConcepts\Views\Student\About.cshtml"
               Write(item.StudentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 26 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day3_CoreMVCConcepts\Views\Student\About.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 27 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day3_CoreMVCConcepts\Views\Student\About.cshtml"
               Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 28 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day3_CoreMVCConcepts\Views\Student\About.cshtml"
               Write(item.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 30 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day3_CoreMVCConcepts\Views\Student\About.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n<br />\n<br />\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26e2d12ad2eb64080852abb7f690afe9655f3fd97022", async() => {
                WriteLiteral("Go to Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
