#pragma checksum "C:\Users\caioo\source\repos\TEsteNN\TEsteNN\Views\Estudantes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "add4e70993102f8716527b39ca3baae502991674"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estudantes_Details), @"mvc.1.0.view", @"/Views/Estudantes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Estudantes/Details.cshtml", typeof(AspNetCore.Views_Estudantes_Details))]
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
#line 1 "C:\Users\caioo\source\repos\TEsteNN\TEsteNN\Views\_ViewImports.cshtml"
using TEsteNN;

#line default
#line hidden
#line 2 "C:\Users\caioo\source\repos\TEsteNN\TEsteNN\Views\_ViewImports.cshtml"
using TEsteNN.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"add4e70993102f8716527b39ca3baae502991674", @"/Views/Estudantes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"056b624a349c890154c8902b69701f86558248d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Estudantes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TEsteNN.Models.EstudantesViewModel>
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\caioo\source\repos\TEsteNN\TEsteNN\Views\Estudantes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(88, 130, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Estudante</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(219, 40, false);
#line 14 "C:\Users\caioo\source\repos\TEsteNN\TEsteNN\Views\Estudantes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(259, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(321, 36, false);
#line 17 "C:\Users\caioo\source\repos\TEsteNN\TEsteNN\Views\Estudantes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(357, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(418, 41, false);
#line 20 "C:\Users\caioo\source\repos\TEsteNN\TEsteNN\Views\Estudantes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Idade));

#line default
#line hidden
            EndContext();
            BeginContext(459, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(521, 37, false);
#line 23 "C:\Users\caioo\source\repos\TEsteNN\TEsteNN\Views\Estudantes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Idade));

#line default
#line hidden
            EndContext();
            BeginContext(558, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(619, 40, false);
#line 26 "C:\Users\caioo\source\repos\TEsteNN\TEsteNN\Views\Estudantes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sexo));

#line default
#line hidden
            EndContext();
            BeginContext(659, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(721, 36, false);
#line 29 "C:\Users\caioo\source\repos\TEsteNN\TEsteNN\Views\Estudantes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Sexo));

#line default
#line hidden
            EndContext();
            BeginContext(757, 29, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>");
            EndContext();
            BeginContext(787, 42, false);
#line 31 "C:\Users\caioo\source\repos\TEsteNN\TEsteNN\Views\Estudantes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cursos));

#line default
#line hidden
            EndContext();
            BeginContext(829, 21, true);
            WriteLiteral("</dt>\r\n        <dd>\r\n");
            EndContext();
#line 33 "C:\Users\caioo\source\repos\TEsteNN\TEsteNN\Views\Estudantes\Details.cshtml"
             if (Model.Cursos != null)
            {
                foreach (var item in Model.Cursos)
                {
                    if (item.Checked)
                    {

#line default
#line hidden
            BeginContext(1038, 158, true);
            WriteLiteral("                        <div>\r\n                            <span class=\"glyphicon glyphicon-list-alt\"></span><Text>&nbsp;</Text>\r\n                            ");
            EndContext();
            BeginContext(1197, 9, false);
#line 41 "C:\Users\caioo\source\repos\TEsteNN\TEsteNN\Views\Estudantes\Details.cshtml"
                       Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1206, 34, true);
            WriteLiteral("\r\n                        </div>\r\n");
            EndContext();
#line 43 "C:\Users\caioo\source\repos\TEsteNN\TEsteNN\Views\Estudantes\Details.cshtml"
                    }
                }
            }
            else
            {

#line default
#line hidden
            BeginContext(1330, 66, true);
            WriteLiteral("                <span class=\"glyphicon glyphicon-list-alt\"></span>");
            EndContext();
            BeginContext(1402, 22, true);
            WriteLiteral("Sem Cursos Registrados");
            EndContext();
#line 48 "C:\Users\caioo\source\repos\TEsteNN\TEsteNN\Views\Estudantes\Details.cshtml"
                                                                                                     
            }

#line default
#line hidden
            BeginContext(1448, 45, true);
            WriteLiteral("        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1493, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "add4e70993102f8716527b39ca3baae5029916748872", async() => {
                BeginContext(1548, 4, true);
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
#line 54 "C:\Users\caioo\source\repos\TEsteNN\TEsteNN\Views\Estudantes\Details.cshtml"
                           WriteLiteral(Model.EstudanteId);

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
            BeginContext(1556, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1564, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "add4e70993102f8716527b39ca3baae50299167411198", async() => {
                BeginContext(1586, 12, true);
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
            BeginContext(1602, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TEsteNN.Models.EstudantesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
