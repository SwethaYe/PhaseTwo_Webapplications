#pragma checksum "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day4_CoreViewModelApplication\Views\Demo\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3854c078acc9a307db0bc7d6a45cef404fb7172f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demo_Details), @"mvc.1.0.view", @"/Views/Demo/Details.cshtml")]
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
#line 1 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day4_CoreViewModelApplication\Views\_ViewImports.cshtml"
using Day4_CoreViewModelApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day4_CoreViewModelApplication\Views\_ViewImports.cshtml"
using Day4_CoreViewModelApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3854c078acc9a307db0bc7d6a45cef404fb7172f", @"/Views/Demo/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a25ad229bdb7fe077aad2b166ea3c0d81f0b3045", @"/Views/_ViewImports.cshtml")]
    public class Views_Demo_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Day4_CoreViewModelApplication.Models.CustomerAddressModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day4_CoreViewModelApplication\Views\Demo\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n<div>\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 11 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day4_CoreViewModelApplication\Views\Demo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day4_CoreViewModelApplication\Views\Demo\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <h4>Customer Information</h4>\r\n    <hr /> \r\n\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day4_CoreViewModelApplication\Views\Demo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day4_CoreViewModelApplication\Views\Demo\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day4_CoreViewModelApplication\Views\Demo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day4_CoreViewModelApplication\Views\Demo\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n     <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 42 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day4_CoreViewModelApplication\Views\Demo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Customer.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 45 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day4_CoreViewModelApplication\Views\Demo\Details.cshtml"
       Write(Html.DisplayFor(model => model.Customer.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>    \r\n</div>\r\n\r\n<div>\r\n    <h4>Address Information</h4>\r\n    <hr /> \r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 55 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day4_CoreViewModelApplication\Views\Demo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 58 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day4_CoreViewModelApplication\Views\Demo\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>   \r\n\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 64 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day4_CoreViewModelApplication\Views\Demo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 67 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day4_CoreViewModelApplication\Views\Demo\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 73 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day4_CoreViewModelApplication\Views\Demo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address.Pincode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 76 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day4_CoreViewModelApplication\Views\Demo\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address.Pincode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n<div>\r\n    ");
#nullable restore
#line 82 "C:\Users\Swetha_y\Desktop\DellFSD_PhaseTwoWebAppProject-master\DellFSD_PhaseTwoWebAppProject-master\Day4_CoreViewModelApplication\Views\Demo\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3854c078acc9a307db0bc7d6a45cef404fb7172f10489", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Day4_CoreViewModelApplication.Models.CustomerAddressModel> Html { get; private set; }
    }
}
#pragma warning restore 1591