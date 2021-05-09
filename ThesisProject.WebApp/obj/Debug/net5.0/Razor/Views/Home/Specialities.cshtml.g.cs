#pragma checksum "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Specialities.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b6f4d813e9cad05919962c558248efead78e243"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Specialities), @"mvc.1.0.view", @"/Views/Home/Specialities.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b6f4d813e9cad05919962c558248efead78e243", @"/Views/Home/Specialities.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"915d3a713abc5f3da507384bf2d841281eba49eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Specialities : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SpecialitiesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("stretched-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DoctorList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Specialities.cshtml"
   
    ViewData["Title"] = "Доктора";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3 class=\"mb-1 text-center\">Выберите специальность</h3>\r\n<div class=\"py-5\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Specialities.cshtml"
             foreach(var card in Model.Specialities)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4\">\r\n                    <div class=\"card mb-1\">\r\n                        <div class=\"card-body\">\r\n                            <h4 class=\"card-title\">");
#nullable restore
#line 15 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Specialities.cshtml"
                                              Write(card.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 16 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Specialities.cshtml"
                                            Write(card.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b6f4d813e9cad05919962c558248efead78e2435922", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-specId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Specialities.cshtml"
                                                                                    WriteLiteral(card.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["specId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-specId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["specId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 21 "C:\Users\vaniuhan\source\repos\Thesis\ThesisProject.WebApp\Views\Home\Specialities.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SpecialitiesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
