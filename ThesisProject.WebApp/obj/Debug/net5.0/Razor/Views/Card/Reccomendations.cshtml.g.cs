#pragma checksum "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Card\Reccomendations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41d0a75ad3f78e861fb79b9175d77a11c06b02ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Card_Reccomendations), @"mvc.1.0.view", @"/Views/Card/Reccomendations.cshtml")]
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
#line 1 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\_ViewImports.cshtml"
using ThesisProject.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\_ViewImports.cshtml"
using ThesisProject.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\_ViewImports.cshtml"
using ThesisProject.WebApp.Models.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\_ViewImports.cshtml"
using ThesisProject.WebApp.Models.Doctors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\_ViewImports.cshtml"
using ThesisProject.WebApp.Models.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\_ViewImports.cshtml"
using ThesisProject.Data.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Card\Reccomendations.cshtml"
using ThesisProject.WebApp.Models.Card;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41d0a75ad3f78e861fb79b9175d77a11c06b02ca", @"/Views/Card/Reccomendations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be9a914762aca7c1c3f178106191c66f9f1ebfac", @"/Views/_ViewImports.cshtml")]
    public class Views_Card_Reccomendations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReccommendationViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Reccomendations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddReccomendation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Card\Reccomendations.cshtml"
  
    ViewData["Title"] = "Examinations";
    var path = Context.Request.Path;
    var query = Context.Request.QueryString;
    var currentUrl = path + query;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41d0a75ad3f78e861fb79b9175d77a11c06b02ca7697", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "41d0a75ad3f78e861fb79b9175d77a11c06b02ca7959", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 10 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Card\Reccomendations.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.PacientId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "41d0a75ad3f78e861fb79b9175d77a11c06b02ca9678", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 11 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Card\Reccomendations.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.ReturnUrl);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <div class=\"d-flex flex-row\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "41d0a75ad3f78e861fb79b9175d77a11c06b02ca11444", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 14 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Card\Reccomendations.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Search);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <button id=\"search-button\" type=\"submit\" class=\"btn btn-primary\">\r\n            <i class=\"bi bi-search\"></i>\r\n        </button>\r\n        <a class=\"btn btn-primary ml-auto\"");
                BeginWriteAttribute("href", " href=\"", 716, "\"", 739, 1);
#nullable restore
#line 18 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Card\Reccomendations.cshtml"
WriteAttributeValue("", 723, Model.ReturnUrl, 723, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Назад</a>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<br />\r\n<div>\r\n    <h5>\r\n        Реккомендации\r\n");
#nullable restore
#line 26 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Card\Reccomendations.cshtml"
         if (User.IsInRole("Doctor") || User.IsInRole("Admin"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41d0a75ad3f78e861fb79b9175d77a11c06b02ca15667", async() => {
                WriteLiteral("Добавть");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Card\Reccomendations.cshtml"
                                                                                           WriteLiteral(currentUrl);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Card\Reccomendations.cshtml"
                 WriteLiteral(Model.PacientId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Card\Reccomendations.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </h5>\r\n</div>\r\n<br />\r\n");
#nullable restore
#line 34 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Card\Reccomendations.cshtml"
 if (Model.Reccomendations.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <tr>\r\n            <th>Тип</th>\r\n            <th>Врач</th>\r\n            <th>Реккомендация</th>\r\n            <th>Начало</th>\r\n            <th>Окончание</th>\r\n        </tr>\r\n");
#nullable restore
#line 44 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Card\Reccomendations.cshtml"
         foreach (var reccomendation in Model.Reccomendations)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Card\Reccomendations.cshtml"
               Write(reccomendation.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Card\Reccomendations.cshtml"
               Write(reccomendation?.Doctor?.Name1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 51 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Card\Reccomendations.cshtml"
                                              Write(reccomendation?.Doctor?.Name2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 52 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Card\Reccomendations.cshtml"
               Write(reccomendation?.Doctor?.Name3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>");
#nullable restore
#line 54 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Card\Reccomendations.cshtml"
               Write(reccomendation.Descripton);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 55 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Card\Reccomendations.cshtml"
               Write(reccomendation.Start);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 56 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Card\Reccomendations.cshtml"
                 if (reccomendation.End.HasValue)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 58 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Card\Reccomendations.cshtml"
                   Write(reccomendation.End.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 59 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Card\Reccomendations.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>-</td>\r\n");
#nullable restore
#line 63 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Card\Reccomendations.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tr>\r\n");
#nullable restore
#line 66 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Card\Reccomendations.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 68 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Card\Reccomendations.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\">\r\n        Нет реккомендаций\r\n    </div>\r\n");
#nullable restore
#line 74 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Card\Reccomendations.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReccommendationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
