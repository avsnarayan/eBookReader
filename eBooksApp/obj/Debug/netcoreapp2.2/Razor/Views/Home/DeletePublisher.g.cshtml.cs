#pragma checksum "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\Home\DeletePublisher.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcede719cf619243b6d0f02eba0bb2bf11be25dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DeletePublisher), @"mvc.1.0.view", @"/Views/Home/DeletePublisher.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/DeletePublisher.cshtml", typeof(AspNetCore.Views_Home_DeletePublisher))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcede719cf619243b6d0f02eba0bb2bf11be25dd", @"/Views/Home/DeletePublisher.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02f8b65e36fa7cbbbdfaa5db72925bbf98a012de", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DeletePublisher : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<eBooksApp.Models.Publisher>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletePublisher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\Home\DeletePublisher.cshtml"
  
    ViewData["Title"] = "DeletePublisher";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(148, 121, true);
            WriteLiteral("\r\n<h1>DeletePublisher</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Publisher</h4>\r\n    <hr />\r\n");
            EndContext();
#line 14 "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\Home\DeletePublisher.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(310, 77, true);
            WriteLiteral("        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(388, 46, false);
#line 18 "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\Home\DeletePublisher.cshtml"
           Write(Html.DisplayNameFor(model => model.Identifier));

#line default
#line hidden
            EndContext();
            BeginContext(434, 75, true);
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(510, 45, false);
#line 22 "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\Home\DeletePublisher.cshtml"
           Write(Html.DisplayFor(modelItem => item.Identifier));

#line default
#line hidden
            EndContext();
            BeginContext(555, 74, true);
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(630, 40, false);
#line 26 "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\Home\DeletePublisher.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(670, 75, true);
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(746, 39, false);
#line 30 "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\Home\DeletePublisher.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(785, 38, true);
            WriteLiteral("\r\n            </dd>\r\n\r\n        </dl>\r\n");
            EndContext();
            BeginContext(825, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(833, 277, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcede719cf619243b6d0f02eba0bb2bf11be25dd6897", async() => {
                BeginContext(901, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(966, 89, true);
                WriteLiteral("            <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n            ");
                EndContext();
                BeginContext(1055, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcede719cf619243b6d0f02eba0bb2bf11be25dd7488", async() => {
                    BeginContext(1077, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1093, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\Home\DeletePublisher.cshtml"
                                             WriteLiteral(item.PublisherId);

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
            BeginContext(1110, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 40 "C:\Users\himan\Desktop\Final_Project_IP\eBooksApp\eBooksApp\Views\Home\DeletePublisher.cshtml"
    }

#line default
#line hidden
            BeginContext(1119, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<eBooksApp.Models.Publisher>> Html { get; private set; }
    }
}
#pragma warning restore 1591