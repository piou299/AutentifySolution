#pragma checksum "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f2b80c756791c9e1b1855bdd9f5cfe599a1e9ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GestionUtilisateurs_EnregistrerUtilisateur), @"mvc.1.0.view", @"/Views/GestionUtilisateurs/EnregistrerUtilisateur.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f2b80c756791c9e1b1855bdd9f5cfe599a1e9ba", @"/Views/GestionUtilisateurs/EnregistrerUtilisateur.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb760fa25d932eb6b758a1bbc95dc7eb3ac7df89", @"/Views/_ViewImports.cshtml")]
    public class Views_GestionUtilisateurs_EnregistrerUtilisateur : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AutentifyAPI.ViewModels.UtilisateurVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DonneesGeneraux", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConsulterListeUtilisateur", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control form-control-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
  
    ViewData["Title"] = "User";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .form-group {
        margin-bottom: 5px;
      /*  padding-left: 50px;*/
    }
</style>

<nav aria-label=""breadcrumb"" class=""nav-breadcrumb"">
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""Home/Index"">Accueil</a></li>
        <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f2b80c756791c9e1b1855bdd9f5cfe599a1e9ba5601", async() => {
                WriteLiteral("Gestions des utilisateurs");
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
            WriteLiteral("</li>\r\n        <li class=\"breadcrumb-item active\" aria-current=\"page\">Ajouter </li>\r\n    </ol>\r\n</nav>\r\n\r\n<div class=\"row\">\r\n\r\n    <div class=\"col-lg-12\">\r\n\r\n");
#nullable restore
#line 26 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
         using (Html.BeginForm("EnregistrerUtilisateur", "GestionUtilisateurs", FormMethod.Post, new { @class = "col-lg-12", enctype = "multipart/form-data" }))
        {



#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\" style=\"margin-top:1em\">\r\n                <div class=\"col-lg-4\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 33 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                   Write(Html.LabelFor(Model => Model.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\" fa fa-user\" aria-hidden=\"true\">*</span>\r\n                        ");
#nullable restore
#line 34 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                   Write(Html.TextBoxFor(Model => Model.Nom, new { @class = "form-control", required = "required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-4\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 39 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                   Write(Html.LabelFor(Model => Model.Prenom));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <span class=\" fa fa-user\" aria-hidden=\"true\">.</span>\r\n                        ");
#nullable restore
#line 40 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                   Write(Html.TextBoxFor(Model => Model.Prenom, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-4\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 45 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                   Write(Html.LabelFor(Model => Model.Telephone));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <span class=\" fa fa-phone\" aria-hidden=\"true\">.</span>\r\n                        ");
#nullable restore
#line 46 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                   Write(Html.TextBoxFor(Model => Model.Telephone, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-lg-4\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 54 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                   Write(Html.LabelFor(Model => Model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\" fa fa-envelope\" aria-hidden=\"true\">*</span>\r\n                        ");
#nullable restore
#line 55 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                   Write(Html.TextBoxFor(Model => Model.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""col-lg-4"">
                    <div class=""form-group"">
                        <label for=""select"" style=""width:100%"">Sexe <span class=""requiredInput"">*</span> </label>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f2b80c756791c9e1b1855bdd9f5cfe599a1e9ba11773", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 62 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                               foreach (Sexe value in Enum.GetValues(typeof(Sexe))) {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f2b80c756791c9e1b1855bdd9f5cfe599a1e9ba12414", async() => {
#nullable restore
#line 63 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                                                  Write(AutentifyAPI.Models.DisplayEnum.GetSexe(value));

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                                   WriteLiteral(value);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" ");
#nullable restore
#line 63 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                                                                                                                }
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 61 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Sexe);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-4\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 70 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                   Write(Html.LabelFor(Model => Model.DateNaissance));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"fa fa-calendar\">*</span>\r\n                        ");
#nullable restore
#line 71 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                   Write(Html.TextBoxFor(Model => Model.DateNaissance, new { @class = "form-control", type ="Date"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-lg-4\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 79 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                   Write(Html.LabelFor(Model => Model.LieuNaissance));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\" fa fa-location-arrow\" aria-hidden=\"true\">*</span>\r\n                        ");
#nullable restore
#line 80 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                   Write(Html.TextBoxFor(Model => Model.LieuNaissance, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-4\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 85 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                   Write(Html.LabelFor(Model => Model.Login));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"fa fa-user-secret\" aria-hidden=\"true\">*</span>\r\n                        ");
#nullable restore
#line 86 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                   Write(Html.TextBoxFor(Model => Model.Login, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-4\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 91 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                   Write(Html.LabelFor(Model => Model.Photo));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"fa fa-soccer-ball-o\">*</span>\r\n                        ");
#nullable restore
#line 92 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                   Write(Html.TextBoxFor(Model => Model.Photo, new { @class = "form-control", type = "file"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""row"">
                <div class=""col-lg-4"">
                    <div class=""form-group"">
                        <label for=""select"" style=""width:100%"">Agence <span class=""requiredInput"">*</span> </label>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f2b80c756791c9e1b1855bdd9f5cfe599a1e9ba20530", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 102 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                             foreach (var item in (List<AutentifyAPI.Models.Agence>)ViewBag.Agen)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f2b80c756791c9e1b1855bdd9f5cfe599a1e9ba21215", async() => {
#nullable restore
#line 104 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                                                          Write(item.Libelle);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 104 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                                   WriteLiteral(item.AgenceId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 105 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 101 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AgenceId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""col-lg-4"">
                    <div class=""form-group"">
                        <label for=""select"" style=""width:100%"">Langue <span class=""requiredInput"">*</span> </label>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f2b80c756791c9e1b1855bdd9f5cfe599a1e9ba25218", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 113 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                             foreach (var item in (List<AutentifyAPI.Models.Langue>)ViewBag.Lang)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f2b80c756791c9e1b1855bdd9f5cfe599a1e9ba25903", async() => {
#nullable restore
#line 115 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                                                          Write(item.Libelle);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 115 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                                   WriteLiteral(item.LangueId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 116 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 112 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LangueId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""col-lg-4"">
                    <div class=""form-group"">
                        <label for=""select"" style=""width:100%"">Rôle <span class=""requiredInput"">*</span> </label>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f2b80c756791c9e1b1855bdd9f5cfe599a1e9ba29904", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 124 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                             foreach (var item in (List<AutentifyAPI.Models.Role>)ViewBag.Role)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f2b80c756791c9e1b1855bdd9f5cfe599a1e9ba30587", async() => {
#nullable restore
#line 126 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                                                        Write(item.Libelle);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 126 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                                   WriteLiteral(item.RoleId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 127 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 123 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RoleId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""row"" style=""margin-top:2em;"">
                <div class=""fa-hover col-md-2 col-sm-4 "">
                    <div class=""form-group"">
                        <button type=""submit"" class=""btn btn-outline-primary"">
                            <span><i class=""fa fa-check-circle-o""></i></span>
                        </button>
                    </div>
                </div>
                <div class=""fa-hover col-md-2 col-sm-4 "">
                    <div class=""form-group"">
                        <button type=""reset"" class=""btn btn-outline-primary"">
                            <span><i class=""fa fa-times-circle-o""></i></span>
                        </button>
                    </div>
                </div>

            </div>
");
#nullable restore
#line 151 "C:\Users\LEONNEL SOFT\source\repos\Versionning Authentify\AutentifySolution\AutentifyAPI\Views\GestionUtilisateurs\EnregistrerUtilisateur.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n</div>\r\n\r\n<style>\r\n        .fa-check-circle-o {\r\n            color: #2da5d5;\r\n        }\r\n\r\n        .fa-times-circle-o {\r\n            color: #d81212;\r\n        }\r\n    </style>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AutentifyAPI.ViewModels.UtilisateurVM> Html { get; private set; }
    }
}
#pragma warning restore 1591