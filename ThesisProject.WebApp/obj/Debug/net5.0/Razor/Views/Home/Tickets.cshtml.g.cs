#pragma checksum "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "104a14c36babedac309714b98df9bb04a4839c19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Tickets), @"mvc.1.0.view", @"/Views/Home/Tickets.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"104a14c36babedac309714b98df9bb04a4839c19", @"/Views/Home/Tickets.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be9a914762aca7c1c3f178106191c66f9f1ebfac", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Tickets : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TicketsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_StatusMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteTicket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Card", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CloseTicket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
  
    ViewData["Title"] = "Tickets";
    var path = Context.Request.Path;
    var query = Context.Request.QueryString;
    var currentUrl = path + query;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h3 class=\"mb-1 text-center\">");
#nullable restore
#line 10 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
                            Write(Model.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 11 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
     if (!string.IsNullOrEmpty(Model.ReturnUrl))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a class=\"btn btn-primary float-right\"");
            BeginWriteAttribute("href", " href=\"", 353, "\"", 376, 1);
#nullable restore
#line 13 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
WriteAttributeValue("", 360, Model.ReturnUrl, 360, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Back</a>\r\n");
#nullable restore
#line 14 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "104a14c36babedac309714b98df9bb04a4839c198677", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 16 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StatusModel);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"py-5\">\r\n    <div class=\"container\">\r\n        <table class=\"table\">\r\n            <tr>\r\n");
#nullable restore
#line 21 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
                 if (User.IsInRole("Admin") || User.IsInRole("Doctor"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th>??????????????</th>\r\n");
#nullable restore
#line 24 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
                 if (User.IsInRole("Admin") || User.IsInRole("Pacient"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th>????????????</th>\r\n                    <th>??????????????</th>\r\n");
#nullable restore
#line 29 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th>????????</th>\r\n                <th>??????????</th>\r\n                <th>????????????????</th>\r\n            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
             foreach (var ticket in Model.Tickets)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n");
#nullable restore
#line 37 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
                     if (User.IsInRole("Admin") || User.IsInRole("Doctor"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 39 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
                       Write(ticket.Pacient?.Name1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 39 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
                                              Write(ticket.Pacient?.Name2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 39 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
                                                                     Write(ticket.Pacient?.Name3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 40 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
                     if (User.IsInRole("Admin") || User.IsInRole("Pacient"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 43 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
                       Write(ticket.Schedule.Doctor?.Name1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 43 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
                                                      Write(ticket.Schedule.Doctor?.Name2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 43 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
                                                                                     Write(ticket.Pacient?.Name3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 44 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
                       Write(ticket.Schedule.Doctor?.Cabinet?.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 45 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 46 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
                   Write(ticket.TicketDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 47 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
                   Write(ticket.Schedule.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "104a14c36babedac309714b98df9bb04a4839c1915628", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
                             WriteLiteral(ticket.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
                                                              WriteLiteral(Model.ReturnUrl);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 51 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
                         if (User.IsInRole("Doctor") || User.IsInRole("Admin"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "104a14c36babedac309714b98df9bb04a4839c1919234", async() => {
                WriteLiteral("????????????????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
                                                                                                  WriteLiteral(ticket.Pacient.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
                                                                                                                                           WriteLiteral(currentUrl);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "104a14c36babedac309714b98df9bb04a4839c1922603", async() => {
                WriteLiteral("?????????????? ??????????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
                                                                                  WriteLiteral(ticket.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
                                                                                                                WriteLiteral(Model.userId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
                                                                                                                                                    WriteLiteral(Model.ReturnUrl);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 58 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Tickets.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TicketsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
