#pragma checksum "D:\project Asp.net core\E-Commerce Clothes\Ecommerceclothes\Ecommerceclothes\Areas\Admin\Views\Womens\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c65d1a85a945506efa204a7d75bcead8d49b196b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Womens_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Womens/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Womens/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Womens_Details))]
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
#line 1 "D:\project Asp.net core\E-Commerce Clothes\Ecommerceclothes\Ecommerceclothes\Areas\Admin\Views\_ViewImports.cshtml"
using Ecommerceclothes;

#line default
#line hidden
#line 2 "D:\project Asp.net core\E-Commerce Clothes\Ecommerceclothes\Ecommerceclothes\Areas\Admin\Views\_ViewImports.cshtml"
using Ecommerceclothes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c65d1a85a945506efa204a7d75bcead8d49b196b", @"/Areas/Admin/Views/Womens/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70d5fb014d8d7175e50b4801aa8c318b28478e61", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Womens_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ecommerceclothes.Models.Womens>
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\project Asp.net core\E-Commerce Clothes\Ecommerceclothes\Ecommerceclothes\Areas\Admin\Views\Womens\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(84, 120, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Womens</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(205, 40, false);
#line 14 "D:\project Asp.net core\E-Commerce Clothes\Ecommerceclothes\Ecommerceclothes\Areas\Admin\Views\Womens\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(245, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(289, 36, false);
#line 17 "D:\project Asp.net core\E-Commerce Clothes\Ecommerceclothes\Ecommerceclothes\Areas\Admin\Views\Womens\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(325, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(369, 41, false);
#line 20 "D:\project Asp.net core\E-Commerce Clothes\Ecommerceclothes\Ecommerceclothes\Areas\Admin\Views\Womens\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(410, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(454, 37, false);
#line 23 "D:\project Asp.net core\E-Commerce Clothes\Ecommerceclothes\Ecommerceclothes\Areas\Admin\Views\Womens\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(491, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(535, 45, false);
#line 26 "D:\project Asp.net core\E-Commerce Clothes\Ecommerceclothes\Ecommerceclothes\Areas\Admin\Views\Womens\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Available));

#line default
#line hidden
            EndContext();
            BeginContext(580, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(624, 41, false);
#line 29 "D:\project Asp.net core\E-Commerce Clothes\Ecommerceclothes\Ecommerceclothes\Areas\Admin\Views\Womens\Details.cshtml"
       Write(Html.DisplayFor(model => model.Available));

#line default
#line hidden
            EndContext();
            BeginContext(665, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(709, 41, false);
#line 32 "D:\project Asp.net core\E-Commerce Clothes\Ecommerceclothes\Ecommerceclothes\Areas\Admin\Views\Womens\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(750, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(794, 37, false);
#line 35 "D:\project Asp.net core\E-Commerce Clothes\Ecommerceclothes\Ecommerceclothes\Areas\Admin\Views\Womens\Details.cshtml"
       Write(Html.DisplayFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(831, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(875, 46, false);
#line 38 "D:\project Asp.net core\E-Commerce Clothes\Ecommerceclothes\Ecommerceclothes\Areas\Admin\Views\Womens\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ShadeColor));

#line default
#line hidden
            EndContext();
            BeginContext(921, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(965, 42, false);
#line 41 "D:\project Asp.net core\E-Commerce Clothes\Ecommerceclothes\Ecommerceclothes\Areas\Admin\Views\Womens\Details.cshtml"
       Write(Html.DisplayFor(model => model.ShadeColor));

#line default
#line hidden
            EndContext();
            BeginContext(1007, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1051, 48, false);
#line 44 "D:\project Asp.net core\E-Commerce Clothes\Ecommerceclothes\Ecommerceclothes\Areas\Admin\Views\Womens\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductTypes));

#line default
#line hidden
            EndContext();
            BeginContext(1099, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1143, 49, false);
#line 47 "D:\project Asp.net core\E-Commerce Clothes\Ecommerceclothes\Ecommerceclothes\Areas\Admin\Views\Womens\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProductTypes.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1192, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1236, 47, false);
#line 50 "D:\project Asp.net core\E-Commerce Clothes\Ecommerceclothes\Ecommerceclothes\Areas\Admin\Views\Womens\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SpecialTags));

#line default
#line hidden
            EndContext();
            BeginContext(1283, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1327, 48, false);
#line 53 "D:\project Asp.net core\E-Commerce Clothes\Ecommerceclothes\Ecommerceclothes\Areas\Admin\Views\Womens\Details.cshtml"
       Write(Html.DisplayFor(model => model.SpecialTags.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1375, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1422, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96475f4dcd15435c9605461ba7f13b70", async() => {
                BeginContext(1468, 4, true);
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
#line 58 "D:\project Asp.net core\E-Commerce Clothes\Ecommerceclothes\Ecommerceclothes\Areas\Admin\Views\Womens\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            BeginContext(1476, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1484, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80457279f8fb48a8ac2e079c7b693578", async() => {
                BeginContext(1506, 12, true);
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
            BeginContext(1522, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ecommerceclothes.Models.Womens> Html { get; private set; }
    }
}
#pragma warning restore 1591
