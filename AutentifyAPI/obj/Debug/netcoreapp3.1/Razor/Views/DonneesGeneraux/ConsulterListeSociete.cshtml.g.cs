#pragma checksum "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\DonneesGeneraux\ConsulterListeSociete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dfab1001258d79594684e591038d73dd8680ca6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DonneesGeneraux_ConsulterListeSociete), @"mvc.1.0.view", @"/Views/DonneesGeneraux/ConsulterListeSociete.cshtml")]
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
#line 1 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\_ViewImports.cshtml"
using AutentifyAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\_ViewImports.cshtml"
using AutentifyAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dfab1001258d79594684e591038d73dd8680ca6", @"/Views/DonneesGeneraux/ConsulterListeSociete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb760fa25d932eb6b758a1bbc95dc7eb3ac7df89", @"/Views/_ViewImports.cshtml")]
    public class Views_DonneesGeneraux_ConsulterListeSociete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AutentifyAPI.Models.Societe>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DonneesGeneraux", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EnregistrerSociete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\DonneesGeneraux\ConsulterListeSociete.cshtml"
  
    ViewData["Title"] = "Société";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<nav aria-label=""breadcrumb"" class=""nav-breadcrumb"">
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""#"">Accueil</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">Liste des Sociétés</li>
    </ol>
</nav>

<div class=""row"" style=""margin-left:450px;"">
    <div class=""fa-hover col-md-2 col-sm-4 "">
        <div class=""form-group"">
            <span style=""font-size:60px;""> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dfab1001258d79594684e591038d73dd8680ca64867", async() => {
                WriteLiteral("<i class=\"fa fa-plus-circle\"></i> ");
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
            WriteLiteral(@"</span>
        </div>
    </div>

</div>

<div class=""container"">
    <hr>

    <table id=""datatable"" class=""table table-sm table-striped table-bordered"" style=""width:100%"">
        <thead>
            <tr>
                <th>#</th>
                <th>Nom de la société</th>
                <th>Sigle</th>
                <th>Adresse</th>
                <th>Email</th>
                <th>Téléphone</th>
                <th>Logo</th>
            </tr>
        </thead>
        <tbody>

");
#nullable restore
#line 39 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\DonneesGeneraux\ConsulterListeSociete.cshtml"
              
                int i = 0;
                foreach (var societe in Model)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            <span>");
#nullable restore
#line 46 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\DonneesGeneraux\ConsulterListeSociete.cshtml"
                              Write(++i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 49 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\DonneesGeneraux\ConsulterListeSociete.cshtml"
                       Write(societe.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 52 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\DonneesGeneraux\ConsulterListeSociete.cshtml"
                       Write(societe.Sigle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 55 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\DonneesGeneraux\ConsulterListeSociete.cshtml"
                       Write(societe.Adresse);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 58 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\DonneesGeneraux\ConsulterListeSociete.cshtml"
                       Write(societe.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 61 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\DonneesGeneraux\ConsulterListeSociete.cshtml"
                       Write(societe.Telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5dfab1001258d79594684e591038d73dd8680ca69613", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1987, "~/IconeSociete/", 1987, 15, true);
#nullable restore
#line 64 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\DonneesGeneraux\ConsulterListeSociete.cshtml"
AddHtmlAttributeValue("", 2002, societe.Logo, 2002, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dfab1001258d79594684e591038d73dd8680ca611254", async() => {
                WriteLiteral("\r\n                                <span style=\"color:red;\" class=\"glyphicon glyphicon-pencil\"></span>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2119, "~/DonneesGeneraux/ModifierSociete/", 2119, 34, true);
#nullable restore
#line 67 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\DonneesGeneraux\ConsulterListeSociete.cshtml"
AddHtmlAttributeValue("", 2153, societe.SocieteId, 2153, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 73 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\DonneesGeneraux\ConsulterListeSociete.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<style>\r\n    .fa-hover {\r\n        margin-bottom: 5px;\r\n    }\r\n</style>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AutentifyAPI.Models.Societe>> Html { get; private set; }
    }
}
#pragma warning restore 1591
