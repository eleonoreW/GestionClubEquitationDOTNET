#pragma checksum "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Activites\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "020496a39824c50b8ca055abd262f1c349bef6ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Activites_Delete), @"mvc.1.0.view", @"/Views/Activites/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Activites/Delete.cshtml", typeof(AspNetCore.Views_Activites_Delete))]
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
#line 1 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\_ViewImports.cshtml"
using ClubEquitation;

#line default
#line hidden
#line 2 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\_ViewImports.cshtml"
using ClubEquitation.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"020496a39824c50b8ca055abd262f1c349bef6ca", @"/Views/Activites/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9eca226b47badce4c5d236614160bf8a5fcc3a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Activites_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClubEquitation.Models.Activite>
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Activites\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(83, 169, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Activite</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(253, 39, false);
#line 15 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Activites\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(292, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(336, 35, false);
#line 18 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Activites\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(371, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(415, 47, false);
#line 21 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Activites\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Commentaire));

#line default
#line hidden
            EndContext();
            BeginContext(462, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(506, 43, false);
#line 24 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Activites\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Commentaire));

#line default
#line hidden
            EndContext();
            BeginContext(549, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(593, 43, false);
#line 27 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Activites\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Details));

#line default
#line hidden
            EndContext();
            BeginContext(636, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(680, 39, false);
#line 30 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Activites\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Details));

#line default
#line hidden
            EndContext();
            BeginContext(719, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(763, 40, false);
#line 33 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Activites\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(803, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(847, 36, false);
#line 36 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Activites\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(883, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(927, 41, false);
#line 39 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Activites\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Duree));

#line default
#line hidden
            EndContext();
            BeginContext(968, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1012, 37, false);
#line 42 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Activites\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Duree));

#line default
#line hidden
            EndContext();
            BeginContext(1049, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1093, 44, false);
#line 45 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Activites\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Capacite));

#line default
#line hidden
            EndContext();
            BeginContext(1137, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1181, 40, false);
#line 48 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Activites\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Capacite));

#line default
#line hidden
            EndContext();
            BeginContext(1221, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1265, 45, false);
#line 51 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Activites\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EstActive));

#line default
#line hidden
            EndContext();
            BeginContext(1310, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1354, 41, false);
#line 54 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Activites\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EstActive));

#line default
#line hidden
            EndContext();
            BeginContext(1395, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1439, 40, false);
#line 57 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Activites\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Lieu));

#line default
#line hidden
            EndContext();
            BeginContext(1479, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1523, 39, false);
#line 60 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Activites\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Lieu.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1562, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1606, 46, false);
#line 63 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Activites\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Professeur));

#line default
#line hidden
            EndContext();
            BeginContext(1652, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1696, 51, false);
#line 66 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Activites\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Professeur.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1747, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1791, 40, false);
#line 69 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Activites\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1831, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1875, 39, false);
#line 72 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Activites\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Type.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1914, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1952, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3470c9de33f54d6580e90537353c20b8", async() => {
                BeginContext(1978, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1988, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0e861e6f8698418c99231ec1403c5ecd", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 77 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Activites\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

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
                BeginContext(2024, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2108, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bc6d9bf3f314940b18d9c3dfc9b5e9a", async() => {
                    BeginContext(2130, 12, true);
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
                BeginContext(2146, 6, true);
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
            BeginContext(2159, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClubEquitation.Models.Activite> Html { get; private set; }
    }
}
#pragma warning restore 1591
