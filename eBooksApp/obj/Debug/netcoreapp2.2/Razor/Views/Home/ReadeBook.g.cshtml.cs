#pragma checksum "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\Home\ReadeBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b795db10f21bfa8847245ed9e7a8f78001f1dd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ReadeBook), @"mvc.1.0.view", @"/Views/Home/ReadeBook.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ReadeBook.cshtml", typeof(AspNetCore.Views_Home_ReadeBook))]
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
#line 1 "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\_ViewImports.cshtml"
using eBooksApp;

#line default
#line hidden
#line 2 "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\_ViewImports.cshtml"
using eBooksApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b795db10f21bfa8847245ed9e7a8f78001f1dd0", @"/Views/Home/ReadeBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02f8b65e36fa7cbbbdfaa5db72925bbf98a012de", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ReadeBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<eBooksApp.Models.Comments>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b795db10f21bfa8847245ed9e7a8f78001f1dd05196", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(106, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\Home\ReadeBook.cshtml"
  
    ViewData["Title"] = "ReadeBook";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(202, 248, true);
            WriteLiteral("\r\n<h1>Read eBook</h1>\r\n\r\n<button class=\"btn btn-primary\" value=\"+\" onclick=\"zoomIn()\" style=\"margin-bottom: 10px\">+</button>\r\n<button class=\"btn btn-primary\" value=\"-\" onclick=\"zoomOut()\" style=\"margin-bottom: 10px\">-</button>\r\n\r\n<div>\r\n    <iframe");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 450, "\"", 469, 1);
#line 15 "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\Home\ReadeBook.cshtml"
WriteAttributeValue("", 456, ViewBag.Path, 456, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(470, 80, true);
            WriteLiteral(" alt=\"No eBook\" id=\"iframe\" width=\"800\" height=\"700\"></iframe>\r\n</div>\r\n<br />\r\n");
            EndContext();
#line 18 "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\Home\ReadeBook.cshtml"
 if (User.IsInRole("Admin") || User.IsInRole("User"))
{
    

#line default
#line hidden
#line 20 "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\Home\ReadeBook.cshtml"
     if (ViewBag.Path != null)
    {

#line default
#line hidden
            BeginContext(647, 54, true);
            WriteLiteral("        <div>\r\n            Comments:\r\n        </div>\r\n");
            EndContext();
            BeginContext(703, 159, true);
            WriteLiteral("        <div>\r\n            <table class=\"table\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(863, 44, false);
#line 31 "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\Home\ReadeBook.cshtml"
                       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(907, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(999, 43, false);
#line 34 "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\Home\ReadeBook.cshtml"
                       Write(Html.DisplayNameFor(model => model.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(1042, 33, true);
            WriteLiteral("\r\n                        </th>\r\n");
            EndContext();
#line 36 "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\Home\ReadeBook.cshtml"
                         if (User.IsInRole("Admin"))
                        {

#line default
#line hidden
            BeginContext(1156, 71, true);
            WriteLiteral("                            <th>\r\n\r\n                            </th>\r\n");
            EndContext();
#line 41 "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\Home\ReadeBook.cshtml"
                        }

#line default
#line hidden
            BeginContext(1254, 78, true);
            WriteLiteral("                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 45 "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\Home\ReadeBook.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1405, 120, true);
            WriteLiteral("                        <tr>\r\n                            <td style=\"padding: 0.5em;\">\r\n                                ");
            EndContext();
            BeginContext(1526, 43, false);
#line 49 "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\Home\ReadeBook.cshtml"
                           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1569, 127, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"padding: 0.5em;\">\r\n                                ");
            EndContext();
            BeginContext(1697, 42, false);
#line 52 "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\Home\ReadeBook.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(1739, 37, true);
            WriteLiteral("\r\n                            </td>\r\n");
            EndContext();
#line 54 "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\Home\ReadeBook.cshtml"
                             if (User.IsInRole("Admin"))
                            {

#line default
#line hidden
            BeginContext(1865, 98, true);
            WriteLiteral("                                <td style=\"padding: 0.5em;\">\r\n                                    ");
            EndContext();
            BeginContext(1963, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b795db10f21bfa8847245ed9e7a8f78001f1dd011767", async() => {
                BeginContext(2024, 14, true);
                WriteLiteral("Delete Comment");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\Home\ReadeBook.cshtml"
                                                                    WriteLiteral(item.CommentId);

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
            BeginContext(2042, 41, true);
            WriteLiteral("\r\n                                </td>\r\n");
            EndContext();
#line 59 "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\Home\ReadeBook.cshtml"
                            }

#line default
#line hidden
            BeginContext(2114, 31, true);
            WriteLiteral("                        </tr>\r\n");
            EndContext();
#line 61 "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\Home\ReadeBook.cshtml"
                    }

#line default
#line hidden
            BeginContext(2168, 64, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n");
            EndContext();
            BeginContext(2236, 49, true);
            WriteLiteral("        <div class=\"comment-class\">\r\n            ");
            EndContext();
            BeginContext(2285, 522, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b795db10f21bfa8847245ed9e7a8f78001f1dd014967", async() => {
                BeginContext(2347, 453, true);
                WriteLiteral(@"
                <div class=""form-group"">
                    <label class=""control-label"">Write Comment:</label>
                </div>
                <div class=""form-group"">
                    <input type=""text"" class=""form-control"" name=""comment"" />
                </div>
                <div class=""form-group"">
                    <input type=""submit"" value=""Add Comment"" class=""btn btn-primary"" />
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 68 "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\Home\ReadeBook.cshtml"
                                            WriteLiteral(ViewBag.eBookId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2807, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 80 "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\Home\ReadeBook.cshtml"
    }

#line default
#line hidden
#line 80 "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\Home\ReadeBook.cshtml"
     
}

#line default
#line hidden
            BeginContext(2835, 37, true);
            WriteLiteral("<div class=\"back-to-publisher\">\r\n    ");
            EndContext();
            BeginContext(2872, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b795db10f21bfa8847245ed9e7a8f78001f1dd018497", async() => {
                BeginContext(2894, 22, true);
                WriteLiteral("Back to Publisher List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2920, 14, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<eBooksApp.Models.Comments>> Html { get; private set; }
    }
}
#pragma warning restore 1591
