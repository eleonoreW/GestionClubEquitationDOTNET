#pragma checksum "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Chevals\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fd1927173234aeac249632b95dca547a5e7a264"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chevals_Details), @"mvc.1.0.view", @"/Views/Chevals/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Chevals/Details.cshtml", typeof(AspNetCore.Views_Chevals_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fd1927173234aeac249632b95dca547a5e7a264", @"/Views/Chevals/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9eca226b47badce4c5d236614160bf8a5fcc3a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Chevals_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClubEquitation.Models.Cheval>
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
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Chevals\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(82, 120, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Cheval</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(203, 39, false);
#line 14 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Chevals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(242, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(286, 35, false);
#line 17 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Chevals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(321, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(365, 49, false);
#line 20 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Chevals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateNaissance));

#line default
#line hidden
            EndContext();
            BeginContext(414, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(458, 45, false);
#line 23 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Chevals\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateNaissance));

#line default
#line hidden
            EndContext();
            BeginContext(503, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(547, 46, false);
#line 26 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Chevals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Descriptif));

#line default
#line hidden
            EndContext();
            BeginContext(593, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(637, 42, false);
#line 29 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Chevals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Descriptif));

#line default
#line hidden
            EndContext();
            BeginContext(679, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(723, 47, false);
#line 32 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Chevals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Commentaire));

#line default
#line hidden
            EndContext();
            BeginContext(770, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(814, 43, false);
#line 35 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Chevals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Commentaire));

#line default
#line hidden
            EndContext();
            BeginContext(857, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(901, 53, false);
#line 38 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Chevals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NbHeureMaxSemaine));

#line default
#line hidden
            EndContext();
            BeginContext(954, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(998, 49, false);
#line 41 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Chevals\Details.cshtml"
       Write(Html.DisplayFor(model => model.NbHeureMaxSemaine));

#line default
#line hidden
            EndContext();
            BeginContext(1047, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1091, 42, false);
#line 44 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Chevals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Taille));

#line default
#line hidden
            EndContext();
            BeginContext(1133, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1177, 38, false);
#line 47 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Chevals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Taille));

#line default
#line hidden
            EndContext();
            BeginContext(1215, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1259, 48, false);
#line 50 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Chevals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Proprietaire));

#line default
#line hidden
            EndContext();
            BeginContext(1307, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1351, 53, false);
#line 53 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Chevals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Proprietaire.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1404, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1448, 40, false);
#line 56 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Chevals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Race));

#line default
#line hidden
            EndContext();
            BeginContext(1488, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1532, 40, false);
#line 59 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Chevals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Race.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(1572, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1619, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3f57ee95cfd475faf87a034b68498b7", async() => {
                BeginContext(1665, 4, true);
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
#line 64 "C:\Users\Eleonore\Documents\archi\ClubEquitation\Views\Chevals\Details.cshtml"
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
            BeginContext(1673, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1681, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4e3ce57d38140d6b4bd55279403e692", async() => {
                BeginContext(1703, 12, true);
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
            BeginContext(1719, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClubEquitation.Models.Cheval> Html { get; private set; }
    }
}
#pragma warning restore 1591
